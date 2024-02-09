using System;

namespace bookStore
{
    class book
    {

        private static int _transactions = 0;

        public void SetTrans()
        {
            _transactions++;
        }

        public int GetTrans() 
        { 
            return _transactions; 
        }


        private int _Id;
        private string _Title;
        private string _Author;

        public book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }

        public book(int i, string title, string author)
        {
            _Id = i;
            _Title = title;
            _Author = author;
        }

        public int GetId()
        {
            return _Id;
        }

        public string GetTitle()
        { return _Title; }

        public string GetAuthor()
        { return _Author; }

        public void SetId(int identification)
        {
            _Id = identification;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }
        class myStore
        {
            static void Main(string[] args)
            {
                book member10 = new book();
                member10.SetTrans();
                member10.SetId(10);
                member10.SetTitle("Call of the Wild");
                member10.SetAuthor("Jack London");

                book member20 = new book();
                member20.SetTrans();
                Console.WriteLine("Please enter the ID: ");
                member20.SetId(int.Parse(Console.ReadLine()));
                Console.WriteLine("Please enter Title: ");
                member20.SetTitle(Console.ReadLine());
                Console.WriteLine("Please enter the Author: ");
                member20.SetAuthor(Console.ReadLine());

                book member30 = new book(30, "White Fang", "Jack london");
                member30.SetTrans();


                Console.WriteLine("Please enter the combination ID: ");
                int combinationID = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the Title: ");
                string combinationTitle = Console.ReadLine();
                Console.WriteLine("Please enter the Author: ");
                String combinationAuthor = Console.ReadLine();
                book member40 = new book(combinationID, combinationTitle, combinationAuthor);
                member40.SetTrans();

                Console.WriteLine($"The book has {member10.GetTrans()} new members");
                displayMembers(member10);
                displayMembers(member20);
                displayMembers(member30);
                displayMembers(member40);

            }
            static void displayMembers(book member)
            {
                Console.WriteLine("Here's your book information");
                Console.WriteLine($"Member ID: {member.GetId()}");
                Console.WriteLine($"Member Title: {member._Title}");
                Console.WriteLine($"Member Author: {member._Author}");
            }







        }
    }

}
