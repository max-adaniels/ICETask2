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
                if (index == 0)
                    return carBrand;
                else if (index == 1)
                    return carModel;
                else if (index == 2)
                    return carColor;
                else if (index == 3)
                    return carYear;
                else if (index == 4)
                    return carPrice;
                return null;
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
                if (attrName == "carBrand")
                    return carBrand;
                else if (attrName == "carModel")
                    return carModel;
                else if (attrName == "carColor")
                    return carColor;
                else if (attrName == "carYear")
                    return carYear;
                else if (attrName == "carPrice")
                    return carPrice;
                return null;
            }
            set
            {
                switch (attrName.ToLower())
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
