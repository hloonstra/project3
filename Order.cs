class Order
{
    public List<FlowerBox> FlowerBoxList {get; private set;}

    public Customer ObjectCustomer { get; set;}
    public string ShippingAddress { get; }

    public float TotalPrice { get; private set;}

    public Order(Customer objectCustomer)
    {
        FlowerBoxList = new List<FlowerBox>();
    }

    public addFlowerbox (FlowerBox box)
    {
        this.FlowerBoxList.Add(box);
        Console.WriteLine("DOne");
    }

    public Order(string firstname, string lastname, string insertion, HomeAdress objectAddress)
    {

    }

    public Order(string firstname, string lastname, string insertion, string address, string city, string postalcode)
    {

    }
}