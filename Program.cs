internal class User
{
   static void Main()
   {
       List<string> users = new List<string>();
       int choice;
       do
       {
           Console.WriteLine("____________________________________________________________");
           Console.WriteLine("Welcome to the User Management System");
           Console.WriteLine("Menu:");
           Console.WriteLine("1. Add Record");
           Console.WriteLine("2. Update Record");
           Console.WriteLine("3. Display Record");
           Console.WriteLine("4. Delete Record");
           Console.WriteLine("5. Exit");
           
           Console.Write("Enter your choice: ");
           choice = Convert.ToInt32(Console.ReadLine());
        
          switch (choice)
          {  
          case 1:
              Console.Write("Enter user name to add: ");
              string newUser = Console.ReadLine();
              users.Add(newUser);
              Console.WriteLine($"User '{newUser}' added successfully.");
              break;
          case 2:
              Console.Write("Enter user name to update: ");
              string oldUser = Console.ReadLine();
              if (users.Contains(oldUser))
              {
                  Console.Write("Enter new user name: ");
                  string updatedUser = Console.ReadLine();
                  int index = users.IndexOf(oldUser);
                  users[index] = updatedUser;
                  Console.WriteLine($"User '{oldUser}' updated to '{updatedUser}'.");
              }
              else
              {
                  Console.WriteLine($"User '{oldUser}' not found.");
              }
              break;
          case 3:
              Console.WriteLine("Current Users:");
              foreach (var user in users)
              {
                  Console.WriteLine(user);
              }
              break;
          case 4:
              Console.Write("Enter user name to delete: ");
              string userToDelete = Console.ReadLine();
              if (users.Remove(userToDelete))
              {
                  Console.WriteLine($"User '{userToDelete}' deleted successfully.");
              }
              else
              {
                  Console.WriteLine($"User '{userToDelete}' not found.");
              }
              break;
          case 5:
              Console.WriteLine("Exiting the User Management System.");
              break;
          default:
              Console.WriteLine("Invalid choice. Please try again.");
              break;
          }

      } while (choice != 5);
   }

}