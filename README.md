# README for C# Product Sales Management Program

This C# program manages product sales by recording information about sellers and their sold products. It offers functionality to add sellers along with their product details, calculate total sales prices, and sort sellers based on their total sales prices.
Program Overview:
Class Prodotto (Product):

    Contains private fields for product code and price.
    Constructors to initialize product code and price.
    Methods to get and set product code and price, read product details from user input, and display product information.

Class Venditore (Seller):

    Contains private fields for seller code and a list of products sold.
    Constructors to initialize seller code and products sold.
    Method to read seller information, calculate total sales prices, add a new product, and display seller information.

Class Program:

    Contains the Main method to execute the program.
    Reads the number of sellers and their information from the user, stores sellers in a list, and displays the sellers along with their sold products.
    Offers functionality to sort sellers by total sales price in ascending or descending order.

How to Use:

    Run the Program:
        Compile and execute the Program.cs file.
        Follow the prompts to input the number of sellers and their product details.

    Input Seller Details:
        Enter seller code and the number of products sold.
        Provide product details for each sold product: code and price.

    View Sorted Seller List:
        Input 'crescente' to sort sellers by total sales price in ascending order or 'decrescente' for descending order.

Program Features:

    Add Sellers & Products: Enter details for sellers and their sold products.
    Calculate Total Sales: Compute the total sales price for each seller.
    Sort Sellers: Sort sellers based on their total sales prices in ascending or descending order.
    Display Seller Information: View sellers' codes and their sold products with prices.

Usage Notes:

    The program allows a maximum of 10 products per seller.
    Input validation for numerical values ensures correct data entry.

Files:

    Prodotto.cs: Defines the structure and functionalities for a product.
    Venditore.cs: Implements the seller class with methods to manage seller and product information.
    Program.cs: Contains the entry point and the main functionality of the application.

Feel free to utilize, modify, or expand this code for educational or personal use. Enjoy managing product sales with this C# program!
