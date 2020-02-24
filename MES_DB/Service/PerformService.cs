
using MES_DB.Vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_DB
{
    public class PerformService
    {
        public List<WorkdiligenceStatusanalysisVO> GetAllWorkStatus()
        {
            PerformDAC dac = new PerformDAC();
            return dac.AllWorkStatuseList();
        }
        public List<PerformSearchVO> GetAllPerformSearch()
        {
            PerformDAC dac = new PerformDAC();
            return dac.GetAllPerformSearch();
        }
        public List<WorkCenterVO> GetAllWorkCenter()
        {
            PerformDAC dac = new PerformDAC();
            return dac.GetAllWorkCenter();
        }
        public List<MaterialManage> GetAllMaterial()
        {
            PerformDAC dac = new PerformDAC();
            return dac.GetAllMaterial();
        }
        public List<RegFaultyVO> GetAllRegFaultyImage()
        {
            PerformDAC dac = new PerformDAC();
            return dac.GetAllRegFaultyImage();
        }

        public List<RegFaultyVO> GetImage(int seq)
        {
            PerformDAC dac = new PerformDAC();
            return dac.GetImage(seq);
        }
        public void InsFaltyImage(string fileName, byte[] img, string WorkOderNo, int faultyNum)
        {
            PerformDAC dac = new PerformDAC();
            dac.InsFaltyImage(fileName, img, WorkOderNo, faultyNum);
        }

        public List<QualityVO> GetAllQuality()
        {
            PerformDAC dac = new PerformDAC();
            return dac.GetAllQuality();
        }
        public void UpdateRegQulityForm(int num, int Seq)
        {
            PerformDAC dac = new PerformDAC();
            dac.UpdateRegQulityForm(num, Seq);
        }
        public void DeleteRegUqlityForm(int num)
        {
            PerformDAC dac = new PerformDAC();
            dac.DeleteRegUqlityForm(num);
        }

        public List<RegProcessVO> GetAllRegProcess()
        {
            PerformDAC dac = new PerformDAC();
            return dac.GetAllRegProcess();
        }
        public void UpdateRegProcess(decimal value, int pk)
        {
            PerformDAC dac = new PerformDAC();
            dac.UpdateRegProcess(value, pk);
        }
        public void DeleteRegProcess(int pk)
        {
            PerformDAC dac = new PerformDAC();
            dac.DeleteRegProcess(pk);
        }

        public void EditPerformSearch(PerformSearchVO edit)
        {
            PerformDAC dac = new PerformDAC();
            dac.EditPerformSearch(edit);
        }
        public List<ProductListVO> GetProductListform()
        {
            PerformDAC dac = new PerformDAC();
            return dac.GetProductListform();
        }
    }
}
