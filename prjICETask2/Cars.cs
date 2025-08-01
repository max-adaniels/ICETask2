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
                    return this.carBrand;
                else if (index == 1)
                    return this.carModel;
                else if (index == 2)
                    return this.carColor;
                else if (index == 3)
                    return this.carYear;
                else if (index == 4)
                    return this.carPrice;
                return null;
            }
            set
            {
                if (index == 0)
                    this.carBrand = (string)value;
                else if (index == 1)
                    this.carModel = (string)value;
                else if (index == 2)
                    this.carColor = (string)value;
                else if (index == 3)
                    this.carYear = (int)value;
                else if (index == 4)
                    this.carPrice = (double)value;
            }
        }

        public Object this[string attrName]
        {
            get
            {
                if (attrName == "carBrand")
                    return this.carBrand;
                else if (attrName == "carModel")
                    return this.carModel;
                else if (attrName == "carColor")
                    return this.carColor;
                else if (attrName == "carYear")
                    return this.carYear;
                else if (attrName == "carPrice")
                    return carPrice;
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("carbrand"))
                    this.carBrand = (string)value;
                else if (attrName.ToLower().Equals("carmodel"))
                    this.carModel = (string)value;
                else if (attrName.ToLower().Equals("carcolor"))
                    this.carColor = (string)value;
                else if (attrName.ToLower().Equals("caryear"))
                    this.carYear = (int)value;
                else if (attrName.ToLower().Equals("carprice"))
                    this.carPrice = (double)value;
            }
        }
    }
}
