namespace ConsoleApp2
{
    class Fight
    {
        public string Fighter1 { get; set; }
        public string Fighter2 { get; set; }
        public string Winner { get; set; }
        public Fight(string[] fighterNames)
        {
            ChooseFighters(fighterNames);
            CalculateResult();

        }

        private void ChooseFighters(string[] fighterNames)
        {
            string fighter1, fighter2;
            do
            {
                fighter1 = (fighterNames[new Random().Next(0, fighterNames.Length)]);
                fighter2 = (fighterNames[new Random().Next(0, fighterNames.Length)]);

            }
            while (fighter1 == fighter2);

            Fighter1 = fighter1;
            Fighter2 = fighter2;
        }

        private void CalculateResult()
        {
            int result = (new Random().Next(0, 2));


            if (result == 1)
            {
                Winner = Fighter1;

            }
            else
            {
                Winner = Fighter2;
            }
        }
    }

}



