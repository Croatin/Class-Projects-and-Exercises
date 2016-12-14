#include <iostream>
#include <cstdlib> 
#include "Checking.h"
#include "Savings.h"
#include "Account.h"
#include "calcInt.h"
using namespace std;

class Savings : public Account
{
      public:
             monthlyProc_sav();
};
              
void Account::monthlyProc() {
     balance = (balance - serviceCharges);
     
     calcInt();
     int deposits = 0;
     int withdrawls = 0;
     double serviceCharges = 0;
}
          
void Savings::monthlyProc_sav() { 
     double x = account.getbalance(); 
     //If the Account class named savings is less than 25
     if (x < 25) {
     
     //And you have over 4 withdrawls                    
     if (withdrawls > 4) {
           
           //Charge $1 for every widthrawl past the 4th one.            
           serviceCharges = (serviceCharges + (withdrawls - 4);

           //Subtract from balance
           balance = (balance - serviceCharges);
        }
        
        else{
               balance = (balance - serviceCharges);
        }
        }
        calcInt();
     int deposits = 0;
     int withdrawls = 0;
     double serviceCharges = 0;
} 

void Checking::monthyProc_sav() { 
     balance = balance - (5 + (0.10 * withdrawls));
     }

     calcInt();
     int deposits = 0;
     int withdrawls = 0;
     double serviceCharges = 0;
        
           
                         
                         
                          
    