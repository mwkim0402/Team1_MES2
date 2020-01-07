﻿using MES_DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class MainForm : Form
    {
        private Point _imageLocation = new Point(25, 5);
        private Point _imgHitArea = new Point(23, 2);
        int CheckBtnIndex = 100;
        bool open = false;
        List<MenuTreeVo> menuList;

        public MainForm()
        {
            InitializeComponent();
            this.tabControl2.DrawMode = TabDrawMode.OwnerDrawFixed;


            this.tabControl2.ItemSize = new Size(120, 20);
            this.tabControl2.SizeMode = TabSizeMode.Fixed;

            // Add the Handler to draw the Image on Tab Pages
            tabControl2.DrawItem += tabControl1_DrawItem;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            SetButtonImage();
            MenuTreeService service = new MenuTreeService();
            menuList = service.GetAllMenu();
            CreateMenuTree("시스템관리");
            trvMenu.Visible = false;
            trvBookMark.Visible = false;
            trvBookMark.Location = new Point(0, 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            trvMenu.Visible = true;
            // 누르는 버튼
            Button btn = (Button)sender;
            // 열려있는 트리뷰가 존재하고
            // 현재 열려있는 버튼과 누르는 버튼이 같을 경우(트리뷰를 닫는다)
            if (btn.TabIndex == CheckBtnIndex && open)
            {
                foreach (var item in pnlMenu.Controls)
                {
                    Button conBtn;
                    if (item is Button)
                    {
                        conBtn = (Button)item;
                        if (conBtn.TabIndex > CheckBtnIndex)
                        {
                            conBtn.Location = new Point(0, conBtn.Location.Y - trvMenu.Size.Height);
                        }
                    }
                }
                open = false;
                trvMenu.Visible = false;
                return;
            }
            // 열려있는 트리뷰가 존재
            // 현재 열려있는버튼과 누르는 버튼이 다를 경우 
            if (open)
            {
                foreach (var item in pnlMenu.Controls)
                {
                    Button conBtn;
                    if (item is Button)
                    {
                        conBtn = (Button)item;
                        //눌려있는 버튼의 Index가 누르는 버튼의 Index보다 적을경우
                        //그 사이에 있는 버튼들을 treeview의 크기만큼 밀어준다
                        if (btn.TabIndex <= CheckBtnIndex)
                        {
                            if (btn.TabIndex < conBtn.TabIndex && CheckBtnIndex >= conBtn.TabIndex)
                            {
                                conBtn.Location = new Point(0, conBtn.Location.Y + trvMenu.Size.Height);
                            }
                        }

                        // 열려있는 버튼과 현재 누른 사이의 버튼들의 위치 재조정
                        if (conBtn.TabIndex <= btn.TabIndex && conBtn.TabIndex > CheckBtnIndex)
                        {
                            conBtn.Location = new Point(0, conBtn.Location.Y - trvMenu.Size.Height);
                            //if (conBtn.TabIndex > CheckBtnIndex)
                            //{
                            //    conBtn.Location = new Point(0, conBtn.Location.Y - trvMenu.Size.Height);
                            //}
                        }
                    }
                }

            }
            // 열려있는 트리뷰가 존재하지 않고
            // 현재 열려있는버튼과 누르는 버튼이 다를 경우 
            else
            {
                foreach (var item in pnlMenu.Controls)
                {
                    Button conBtn;
                    if (item is Button)
                    {
                        conBtn = (Button)item;
                        if (conBtn.TabIndex > btn.TabIndex)
                        {
                            conBtn.Location = new Point(0, conBtn.Location.Y + trvMenu.Size.Height);
                        }
                    }
                }
            }

            CheckBtnIndex = btn.TabIndex;
            trvMenu.Location = new Point(0, btn.Location.Y + btn.Size.Height);
            CreateMenuTree(btn.Text.Trim());
            open = true;
        }

        private void CreateMenuTree(string ParentMenu)
        {
            trvMenu.Nodes.Clear();
            trvMenu.ItemHeight = 25;
            List<MenuTreeVo> childMenu = (from item in menuList
                                          where item.Parent_Screen_Code == ParentMenu
                                          orderby item.Sort_index
                                          select item).ToList();
            trvMenu.Nodes.Add(ParentMenu);
            foreach (MenuTreeVo item in childMenu)
            {
                trvMenu.Nodes[0].Nodes.Add(item.Screen_Code);
            }
            trvMenu.ExpandAll();
        }

        private void SetButtonImage()
        {
            btnLogo.Image = new Bitmap(System.Windows.Forms.Application.StartupPath + @"\image\teamlogo.png");
            btnCreate.Image = new Bitmap(System.Windows.Forms.Application.StartupPath + @"\image\Report2_32x32.png");
            btnSave.Image = new Bitmap(System.Windows.Forms.Application.StartupPath + @"\image\Action_Save_New_32x32.png");
            btnEdit.Image = new Bitmap(System.Windows.Forms.Application.StartupPath + @"\image\Edit_32x32.png");
            btnDelete.Image = new Bitmap(System.Windows.Forms.Application.StartupPath + @"\image\DeleteList_32x32.png");
            btnSearch.Image = new Bitmap(Application.StartupPath + @"\image\searchBtn.png");
            pictureBox1.Image = new Bitmap(Application.StartupPath + @"\image\mark.jpg");
            foreach (var item in pnlMenu.Controls)
            {
                if (item is Button)
                {
                    Button btn = (Button)item;
                    btn.Image = new Bitmap(System.Windows.Forms.Application.StartupPath + @"\image\buttonImage.png");
                }
            }
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                // Close Image to draw
                Image img = new Bitmap(System.Windows.Forms.Application.StartupPath + @"\image\Remove_16x16.png");
                Rectangle r = e.Bounds;
                r = this.tabControl2.GetTabRect(e.Index);
                r.Offset(2, 2);
                
                Brush TitleBrush = new SolidBrush(Color.Black);
                Font f = this.Font;

                string title = this.tabControl2.TabPages[e.Index].Text;
                this.tabControl2.SizeMode = TabSizeMode.Fixed;
                e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));
                e.Graphics.DrawImage(img, new Point(r.X + (this.tabControl2.GetTabRect(e.Index).Width - _imageLocation.X - 2), _imageLocation.Y - 3));
            }
            catch (Exception err) { System.Windows.Forms.MessageBox.Show(err.Message); }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tc = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.tabControl2.GetTabRect(tc.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = this.tabControl2.GetTabRect(tc.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 16;
            r.Height = 16;
            if (r.Contains(p))
            {
                TabPage TabP = (TabPage)tc.TabPages[tc.SelectedIndex];
                tc.TabPages.Remove(TabP);
            }
       
            // Form tempChild = this.ActiveMdiChild;
            // tempChild.Close();
        }

        #region 폼동적생성
        /// <summary>
        /// 트리뷰 자식메뉴클릭시 폼생성
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trvBookMark_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeView trv = (TreeView)sender;
            if (trv.SelectedNode == null)
            {
                return;
            }
            MenuTreeVo selectMenu = menuList.Find(x => x.Screen_Code.Contains(trv.SelectedNode.Text));
            if (selectMenu.Parent_Screen_Code != null)
            {
                // 중복된 페이지를 여는 것을 막는다.
                foreach (TabPage page in tabControl2.TabPages)
                {
                    if (page.Text == selectMenu.Screen_Code)
                    {
                        tabControl2.SelectedTab = page;
                        return;
                    }
                }
                newForm(selectMenu.Form_Name, selectMenu.Screen_Code.Trim());
                lblLocation.Text = "위치 정보 : " + selectMenu.Parent_Screen_Code.Trim() + " > " + selectMenu.Screen_Code.Trim();
            }
            
        }
        /// <summary>
        /// 새로운 폼 생성
        /// </summary>
        /// <param name="formName">폼이름</param>
        private void newForm(string formName, string Form_Code)
        {
            try
            {
                string nameSpace = "AdminForm"; //네임스페이스 명
                Assembly cuasm = Assembly.GetExecutingAssembly();
                //string Format 의 따옴표와 마침표 주의!!

                Form frm = (Form)cuasm.CreateInstance(string.Format("{0}.{1}", nameSpace, formName));

                frm.TopLevel = false;
                tabControl2.TabPages.Add(Form_Code);
                tabControl2.TabPages[tabControl2.TabPages.Count - 1].Controls.Add(frm);
                tabControl2.SelectedTab = tabControl2.TabPages[tabControl2.TabPages.Count - 1];
                frm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            #endregion
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.Name == "btnMenu")
            {
                setVisiblMenu(true);
                if (!open)
                {
                    trvMenu.Location = new Point(0, 218);
                    trvMenu.Visible = false;
                }
            }
            else
            {
                trvBookMark.Nodes.Clear();
                setVisiblMenu(false);
                trvBookMark.Nodes.Add("사용자그룹관리");
            }
        }

        private void setVisiblMenu(bool bVisible)
        {
            button1.Visible = bVisible;
            button2.Visible = bVisible;
            button3.Visible = bVisible;
            button4.Visible = bVisible;
            button5.Visible = bVisible;
            button6.Visible = bVisible;
            button7.Visible = bVisible;
            trvMenu.Visible = bVisible;
            trvBookMark.Visible = !bVisible;
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)sender;
            if(tc.SelectedTab == null)
            {
                lblLocation.Text = "";
                return;
            }
            MenuTreeVo selectMenu = menuList.Find(x => x.Screen_Code.Contains(tc.SelectedTab.Text));
            lblLocation.Text = "위치 정보 : " + selectMenu.Parent_Screen_Code.Trim() + " > " + selectMenu.Screen_Code.Trim();
        }
    }
}