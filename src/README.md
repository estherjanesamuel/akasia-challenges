# Auction Online

simple flowchart for an online auction system that includes functionality for listing products and bidding:

```bash
Start
  |
  v
Seller lists product
  |
  v
Buyers bid on product
  |
  v
Highest bid wins
  |
  v
End
```

The bidding process for an online auction can vary depending on the auction site, but most websites follow a similar bidding flow. Here are the general steps to bidding in an online auction:

- Create an online account: Before you can start bidding, you must create an account on the auction website. Most sites also allow you to store a payment method on the account to simplify your auction experience
- Locate the auction page: Visit an auctioneer’s website to find their page and a list of their upcoming auctions. The listings will include the link to the bidding page, the auction dates and other important information. Simply follow the link to the auction page and log in with your account
- Register for the auction: You will find the option to register for the event on the auction page. Registration includes a form for you to fill out so the auctioneer can verify your identity. The information needed depends on the auctioneer. Many auctioneers will require you to submit a credit card number for verification 
- Obtain approval from the auctioneer: Your auctioneer will review your registration information to determine whether you are a legitimate bidder. This process usually takes between one to two days 

Once you are approved and registered, you can start bidding on items. The online bidding process starts by offering the product at a predetermined base price. Every time a bid is placed, the product’s price increases by a fixed amount.Bidders also have to pay a small fee each time they bid

## 💻 Technologies

### Back-end
- [.NET Core](https://dotnet.microsoft.com/en-us/) - .NET is the free, open-source, cross-platform framework for building modern apps and powerful cloud services.
- [PostgreSQL](https://www.postgresql.org/) -  An open-source relational database management system
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/) - Entity Framework (EF) Core is a lightweight, extensible, open source and cross-platform version of the popular Entity Framework data access technology.
- [Cloudinary](https://cloudinary.com/) - For image uploading and manipulation
- [Docker](https://www.docker.com/) - A platform for developing, shippinh and running applications


### Front-end
- [ReactJS](https://reactjs.org/) - Frontend framework
- [Next.js](https://nextjs.org/) - React framework that enables server-side rendering
- [Tailwind CSS](https://tailwindcss.com/) - A utility-first CSS framework
- [Emotion](https://emotion.sh/) - CSS-in-JS library designed for high performance style composition
- [Formik](https://formik.org/) - React framework for building forms
- [Yup](https://github.com/jquense/yup) - A form validation library

---------------------------------------

# Gas Station

flowchart for a gas station that serves two-wheeler and four-wheeler vehicles with three different gasoline types: Pertalite, Pertamax, and PertamaxTurbo. There are 2 stations for Pertalite, 2 for Pertamax, and 1 for PertamaxTurbo.

```bash
Start
|
|
V
Vehicle enters gas station
|
|
V
Is the vehicle a two-wheeler or four-wheeler?
|                        |
|                        |
V                        V
Two-wheeler             Four-wheeler
|                        |
|                        |
V                        V
Which gasoline type?    Which gasoline type?
|                        |
|                        |
V                        V
Pertalite               Pertalite
Pertamax                Pertamax
PertamaxTurbo           PertamaxTurbo
|                        |
|                        |
V                        V
Enter queue for         Enter queue for 
selected gasoline type  selected gasoline type
|                        |
|                        |
V                        V
Wait for available      Wait for available 
station                 station
|                        |
|                        |
V                        V
Fill up at station      Fill up at station
|
|
V
End
```

> This flowchart shows the process of a vehicle entering the gas station and selecting the appropriate gasoline type. The vehicle then enters the queue for the selected gasoline type and waits for an available station. Once a station becomes available, the vehicle moves forward to fill up. This is just one possible way to represent the process and you can modify it to better suit your needs.

