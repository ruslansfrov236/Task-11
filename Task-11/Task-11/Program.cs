using System;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        bool isMenu = true;
       
        ArrayList arrayList = new ArrayList();

        void Dialog()
        {
            Console.WriteLine("Do you want to continue or not? Yes, go ahead, No, don't go ahead");
            string dialog = Console.ReadLine();

            switch (dialog)
            {
                case "Yes":
                    isMenu = true;
                
                    break;

                case "No":
                    isMenu = false;
                    break;
            }
        }

        void AddArray()
      
                Console.Write("Enter a name:");
                string name = Console.ReadLine();
                arrayList.Add(name);
       

            Dialog();
        }

        void GetAllArray()
        {
            if(arrayList.Count == 0)
            {
                Console.WriteLine("Not Found");
            }
            foreach (var item in arrayList)
            {
                Console.WriteLine($"Name: {item}");
            }
            Dialog();
        }

        void RemovArray()
        {
            Console.WriteLine("Enter the name to remove:");
            string name = Console.ReadLine();

            arrayList.Remove(name);
            Dialog();
        }

        void RemoveAtArray()
        {
            if (arrayList.Count > 0)
            {
                arrayList.RemoveAt(arrayList.Count - 1);
            }
            else
            {
                Console.WriteLine("Array is empty.");
            }

            Dialog();
        }

        void TrimToSize()
        {
            arrayList.TrimToSize();

            Console.WriteLine($"ArrayList Trimmed to Size. Current Capacity: {arrayList.Capacity}");


            Dialog();
        }

        void AddRangeArray()
        {

            Console.Write("Enter the number of names:");
            int x = int.Parse(Console.ReadLine());

            string[] names = new string[x];
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Enter a name:");
                names[i] = Console.ReadLine();
            }

            arrayList.AddRange(names);
            Dialog();
        }

        void ArrayCount()
        {
            Console.WriteLine($"Array Count: {arrayList.Count}");
            Dialog();
        }

        void ArrayCapacity()
        {
            Console.WriteLine($"Array Capacity: {arrayList.Capacity}");
            Dialog();
        }

        while (isMenu)
        {
            Console.WriteLine("\t\t\t\t\t\t\t Menu \n" +
                "1. Array Get All \n" +
                "2. Add method \n" +
                "3. Remove method\n" +
                "4. RemoveAt method\n" +
                "5. TrimToSize method\n" +
                "6. AddRange method\n" +
                "7. Count \n" +
                "8. Capacity \n" +
                "9. Exit \n");
            Console.Write("choose:");
            int secim_et;
            if (int.TryParse(Console.ReadLine(), out secim_et))
            {
                switch (secim_et)
                {
                    case 1:
                        GetAllArray();
                        break;
                    case 2:
                        AddArray();
                        break;
                    case 3:
                        RemovArray();
                        break;
                    case 4:
                        RemoveAtArray();
                        break;
                    case 5:
                        TrimToSize();
                        break;
                    case 6:
                        AddRangeArray();
                        break;
                    case 7:
                        ArrayCount();
                        break;
                    case 8:
                        ArrayCapacity();
                        break;
                    case 9:
                        isMenu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
