//Engin Yenice
using System;
namespace DirectoryExample
{
    class BookDirectory<TBookNumber,TBookName>
    {
        TBookName[]     bookNameList;
        TBookNumber[] bookNumberList;

        public BookDirectory()
        {
            bookNameList = new TBookName[0];
            bookNumberList = new TBookNumber[0];
        }
        public void Add(TBookNumber bookNumber,TBookName bookName)
        {
            try
            {
                if (BookNumberControl(bookNumber) 
                    && bookName.ToString().Length > 0
                    && bookNumber != null) { 
                TBookNumber[] tempNumberList = new TBookNumber[Lenght() + 1];
                TBookName[] tempNameList = new TBookName[Lenght() + 1];
                
                for(int i = 0; i< Lenght(); i++)
                {
                    tempNumberList[i] = bookNumberList[i];
                    tempNameList[i] = bookNameList[i];
                }
                tempNameList[tempNameList.Length - 1] = bookName;
                tempNumberList[tempNumberList.Length - 1] = bookNumber;


                bookNameList = tempNameList;
                bookNumberList = tempNumberList;
                Console.WriteLine(bookNumber + " - " + bookName + ", successfully added to the list");
                } else
                {

                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("An error occurred while registering");
                    Console.WriteLine(bookNumber + " - " + bookName);
                    Console.WriteLine("-----------------------------------");
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong. " + e.ToString());
                throw;
            }
        }
        public void GetAll()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("The total number of books is " + Lenght());
            Console.WriteLine("List of all books");
            for (int i = 0; i < Lenght(); i++)
            {
                Console.WriteLine(i+1 +") Number: "+ bookNumberList[i] + " - Name: " + bookNameList[i]);
            }
            Console.WriteLine("-----------------------------------");
        }

        public int Lenght()
        {
            return bookNameList.Length;
        }
        private bool BookNumberControl(TBookNumber bookNumber)
        {
            foreach (var item in bookNumberList)
            {
                if(item.ToString() == bookNumber.ToString())
                {
                    
                    return false;
                }
            }
            return true;
        }
    }
}
