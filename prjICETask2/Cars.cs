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
                if (index == 0)
                    carBrand = (string)value;
                else if (index == 1)
                    carModel = (string)value;
                else if (index == 2)
                    carColor = (string)value;
                else if (index == 3)
                    carYear = (int)value;
                else if (index == 4)
                    carPrice = (double)value;
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
                if (attrName.ToLower().Equals("carBrand"))
                    carBrand = (string)value;
                else if (attrName.ToLower().Equals("carModel"))
                    carModel = (string)value;
                else if (attrName.ToLower().Equals("carColor"))
                    carColor = (string)value;
                else if (attrName.ToLower().Equals("carYear"))
                    carYear = (int)value;
                else if (attrName.ToLower().Equals("carPrice"))
                    carPrice = (double)value;
            }
        }
    }
}
