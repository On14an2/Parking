namespace parkovka
{
    internal class CarClass
    {
        private string Mark;
        private string Model;
        private string Color;
        private string Number;
        private string Time;

        public string mark
        {
            get => Mark;
        }

        public string model
        {
            get => Model;
        }

        public string color
        {
            get => Color;
        }

        public string number
        {
            get => Number;
        }

        public string time
        {
            get => Time;
        }

        public CarClass(string nmark = "Неизвестная марка", string nmodel = "Неизвестная модель",
            string ncolor = "Неизвестный цвет", string nnumber = "Неизвестный номер",
            string ntime = "Неизвестное время")
        {
            this.Mark = nmark;
            this.Model = nmodel;
            this.Color = ncolor;
            this.Number = nnumber;
            this.Time = ntime;
        }
    }
}