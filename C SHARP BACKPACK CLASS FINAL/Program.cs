
// Backpack Class Assignment // 

class Backpack
{
    public string Color;
    public string Size;
    public bool Open = false;
    public string[] items = new string[] {};
    // Define constructor method
    public Backpack(string color, string size)
    {
        Color = color;
        Size = size; 

    }

    // Methods (Functions / Behaviour)
    public void OpenBag()
    {
        Open = true;
        Console.WriteLine("Bag opened!");

    }

    public void CloseBag()
    {
        Open = false;
        Console.WriteLine("Bag closed!");
    }

    public void PutIn(string item)
    {
        if (Open == true)
        {
            item = item.ToLower();
            List<string> list = new List<string>(items.ToList());
            list.Add(item);
            items = list.ToArray();
            Console.WriteLine("Item successfully placed in bag!");
        } else
        {
            Console.WriteLine("Bag is not open!");
        }
    }
    public void TakeOut(string placedItem)
    {
        if (Open == true)
        {
            placedItem = placedItem.ToLower();
            var check = Array.Exists(items, x => x == placedItem);
            items = items.Where(x => x != placedItem).ToArray();

            if (check == true)
            {
                Console.WriteLine("Item was found! Item is now out of the bag.");
            } else
            {
                Console.WriteLine("Item was not found. Please search harder!");
            }
            
        } else
        {
            Console.WriteLine("Bag is not open!");
        }
        
    }


    

   

    // TASK 2 \\ 



    static void Main(string[] args)
    {
        Backpack SmallBlue = new Backpack("Blue", "Small");
        Backpack MediumRed = new Backpack("Red", "Medium");
        Backpack LargeGreen = new Backpack("Green", "Large");



        // TASK 3 \\

        SmallBlue.OpenBag();
        SmallBlue.PutIn("Lunch");
        SmallBlue.PutIn("Jacket");
        SmallBlue.CloseBag();
        SmallBlue.OpenBag();
        SmallBlue.TakeOut("Jacket");
        SmallBlue.CloseBag();

    }



}


    
   

