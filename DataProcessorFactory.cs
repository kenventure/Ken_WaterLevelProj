using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterLevelData
{
    class DataProcessorFactory
    {
        public static DataProcessor GetProcessor (string str)
        {
            switch (str)
            {
                case "csv":
                    return new CsvDataProcessor();
                default:
                    return null;
            }
            
        }
    }
}
