using Heranca.Entities;

namespace Heranca;

class Program
{
    static void Main(string[] args)
    {
        
        
        Account acc = new  Account(1001, "Alex", 0.0);
        BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);
        
        
        // UPCASTING
        Account acc1 = bacc;
        Account acc2 = new BusinessAccount(1003, "John", 0.0, 200.0);

        // DOWNCASTING
        Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 300.0);
        BusinessAccount acc4 = (BusinessAccount)acc3;

        // if (acc3 is BusinessAccount){
        //     BusinessAccount acc5 = (BusinessAccount)acc3;
        // }
        
        if (acc3 is BusinessAccount){
            BusinessAccount acc5 = acc3 as BusinessAccount;
        }
        
        
    }
}