using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjICETask2
{
    public class Cars
    {
        private string carBrand, carModel, carColor;
        private int carYear;
        private double carPrice;

        public Cars(string carBrand, string carModel, string carColor, int carYear, double carPrice)
        {
            this.carBrand = carBrand;
            this.carModel = carModel;
            this.carColor = carColor;
            this.carYear = carYear;
            this.carPrice = carPrice;
        }

        public Object this[int index]
        {
            get
            {
                return index switch
                {
                    0 => carBrand,
                    1 => carModel,
                    2 => carColor,
                    3 => carYear,
                    4 => carPrice,
                    _ => null
                };
            }
            set
            {
                switch (index)
                {
                    case 0:
                        carBrand = (string)value;
                        break;
                    case 1:
                        carModel = (string)value;
                        break;
                    case 2:
                        carColor = (string)value;
                        break;
                    case 3:
                        carYear = (int)value;
                        break;
                    case 4:
                        carPrice = (double)value;
                        break;
                }
            }
        }

        public Object this[string attrName]
        {
            get
            {
                return attrName switch
                {
                    "carBrand" => carBrand,
                    "carModel" => carModel,
                    "carColor" => carColor,
                    "carYear" => carYear,
                    "carPrice" => carPrice,
                    _ => null
                };
            }
            set
            {
                switch (attrName)
                {
                    case "carBrand":
                        carBrand = (string)value;
                        break;
                    case "carModel":
                        carModel = (string)value;
                        break;
                    case "carColor":
                        carColor = (string)value;
                        break;
                    case "carYear":
                        carYear = (int)value;
                        break;
                    case "carPrice":
                        carPrice = (double)value;
                        break;
                }
            }
        }
    }
}
