using System;
namespace darkroom
{
    class Choice
    {
        private String one;
        private String two;
        private String three;
        private String four;

        public Choice(String one, String two, String three, String four)
        {
            this.one = one;
            this.two = two;
            this.three = three;
            this.four = four;
        }

        public void getOptions()
        {
            Console.WriteLine(this.one);
            Console.WriteLine(this.two);
            Console.WriteLine(this.three);
            Console.WriteLine(this.four);
        }
    }
}