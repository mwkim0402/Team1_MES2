
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
        public List<GVMonitoringVO> GetAllMonitoring()
        {
            PerformDAC dac = new PerformDAC();
            return dac.GetAllMonitoring();
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
        public void InsFaltyImage(string fileName, string filePath, string WorkOderNo,int faultyNum)
        {
            PerformDAC dac = new PerformDAC();
            dac.InsFaltyImage(fileName, filePath, WorkOderNo,faultyNum);
        }

        public List<QualityVO> GetAllQuality()
        {
            PerformDAC dac = new PerformDAC();
            return dac.GetAllQuality();
        }

        public List<RegProcessVO> GetAllRegProcess()
        {
            PerformDAC dac = new PerformDAC();
            return dac.GetAllRegProcess();
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
