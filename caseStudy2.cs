// public abstract class Staff
// {
//     public string Name { get; set; }
//     public abstract void Work();
// }
 
// public class Waiter : Staff
// {
//     public List<string> Orders = new List<string>();
 
//     public void TakeOrder(string order)
//     {
//         Orders.Add(order);
//     }
 
//     public void ServeFood()
//     {
//         Orders.Clear();
//     }
 
//     public override void Work()
//     {
//         Console.WriteLine($"{Name} is serving customers.");
//     }
// }
 
// public class Chef : Staff
// {
//     public List<string> Menu = new List<string>();
 
//     public void Cook(string dish)
//     {
//         Menu.Add(dish);
//         Console.WriteLine($"{Name} cooked {dish}");
//     }
 
//     public override void Work()
//     {
//         Console.WriteLine($"{Name} is cooking.");
//     }
// }
// public class VipWaiter : Waiter
// {
//     public void PriorityServe()
//     {
//         Console.WriteLine("Priority service for VIP guest completed.");
//     }
 
//     public override void Work()
//     {
//         Console.WriteLine("Serving VIP guest.");
//     }
// }
// // Unit Tests
// [TestClass]
// public class RestaurantTests
// {
//     [TestMethod]
//     public void TestWaiterServeFood()
//     {
//         Waiter w = new Waiter();
//         w.TakeOrder("Burger");
//         w.ServeFood();
 
//         //Assert.AreEqual(1, w.Orders.Count); // This fails
//         Assert.AreEqual(0, w.Orders.Count);
//     }
 
//     [TestMethod]
//     public void TestChefCook()
//     {
//         Chef c = new Chef();
//         c.Cook("Pasta");
 
//         Assert.IsTrue(c.Menu.Contains("Pasta"));
//     }
// }