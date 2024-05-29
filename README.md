# Online Car Rental Website

**Login Page:** 
- On this page you can *`Log in`* as a Customer or Admin by ticking the appropriate boxes, you can also create an account, use the *`Sign up`* option, if you don't already have one.

![](/ReadmeImg/LogIn.jpg)

**Sign up page:** 
- Here you create an account, and the data will be stored in a database:

![](/ReadmeImg/SignUp.png)


If you have logged in as a **`Customer`**, you will be redirected to the **`Cars`** page where you can see all the available cars and the details about them that you can rent for a certain period of time, the date is selected from the adjacent Date Picker:

![](/ReadmeImg/CustCars.png)

In the **`Pending Rents`** page we have the rents that are ongoing. We have the option to select a rent from the `Select` button next to the table and to cancel the selected rent by pressing the `Delete` button:

![](/ReadmeImg/PendingRents.png)
We also have the `Logout` option that directs us to the `Login` page.

Logging in as **Admin** is `unique`, and if I log in as Admin I will be redirected to the `Home` page where I can view all the cars:

![](/ReadmeImg/Home.png)

In the **`Car`** page in `Admin`, a table with car data is displayed, where you can select cars using the `Select` button from the table, and the fields on the left side will be filled in `automatically`, after which we can`Edit` the selected car, we can `Add` a new car or we can `Delete` the selected car (all data will be modified in the database):

![](/ReadmeImg/AdminCars.png)

In the **`Customers`** page in Admin, a table with the data of all customers is displayed, where you can select the customer using the `Select` button from the table, and the fields on the left side will be filled in `automatically`, after which we can `Edit` the customer, we can `Add` a new one customer or we can `Delete` the selected customer (all data will be modified in the database):

![](/ReadmeImg/AdminCust.png)

In the **`Rentals`** page in Admin we have a table with all the cars that are rented and details about the rental. We can `return` (using the `Return` button) a `selected` car (using the `Select` button in the table) specifying whether the return was made with a `delay (Delay)` and establishing a certain `delay penalty (Fine)`:

![](/ReadmeImg/Rentals.png)

In the **`Returns`** page in Admin we have a table with `all returned cars` and details about their return:

![](/ReadmeImg/Returns.png)

And int the end we have the `Logout` button that directs us to the **`Login`** page.