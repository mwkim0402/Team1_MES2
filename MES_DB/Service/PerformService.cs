﻿
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
        public List<PerformSearchVO> GetAllPerformSearch(DateTime Start,DateTime End)
        {
            PerformDAC dac = new PerformDAC();
            return dac.GetAllPerformSearch(Start,End);
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
    }
}
