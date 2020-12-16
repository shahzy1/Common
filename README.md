# Common
This is MVC Core application focused on Shopping experience. Here are the requirments;

Write a program for the following scenario.  It should take between 30 minutes to 1 hour to write this code.
 
Your code needs to process an order placed by a user. Order is for a single product. 

Check inventory of the product from a persistent store. 

     bool CheckInventory(string productId, int qty)

If there are enough quantities in the store,
 
a. Call a 3rd party payment service to verify the credit card info.  For simplicity assume incoming Order contains user's credit card. Payment gateway has the following service interface. Every time we call this interface they charge us a fee!
        	
    bool ChargePayment(string creditCardNumber, decimal amount)
 
b. Send an e-mail to shipping department instructing them to ship the order.  Do not send real emails, while running your tests.

You are expected to  write unit tests.   Do not write full scale implementations for data access, web services.   
