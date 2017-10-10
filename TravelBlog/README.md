# Travel Blog

## By Kaili Nishihira and Michael Woldemedihin

#### _This is dedicated web site to post our travel experiences all over the world., 10.10.17_


## Description

_This is dedicated web site to post our travel experiences all over the world._

|| Behavior  | Input  | Output  |
|---|---|---|---|
|1| User may view a list of all locations on the Home/Index view  | Click `Home` in navigation bar  | View displays buttons with location's names `USA, Seattle`|
|2| User may view a location's details. <li>Click location's button in Index view</li>  | Click `USA, Seattle`  | List of all experiences in Seattle should display. <br>  <br> > Space needle<br> > Flat Stick bar<br> |
|3| User may enter a new stylist <li>Click `Add Stylist` in navigation bar</li> <li>View returns a form to enter the stylist's information| Enter a new stylist: <br> First Name: 'Vidal' <br> Last Name: 'Sassoon' <br> Women's Cut: $ '170' <br> Men's Cut: $ '150' <br> Click `Add Stylist`| Index view of all stylists: <br> ... <br> `Vidal` <br> ... |
|4| User may add a new client to a specific stylist <li>In stylist's details view, enter client's information into the form 'New client for (stylist's name)'</li> | Enter a new client for Chris McMillan: <br> First Name: Lisa <br> Last Name: Smith <br> Phone: 808-555-1234 <br> Email: lisa.smith@gmail.com <br> Click `Add client` | Chris McMillan Client List: <br> ... <br> Smith, Lisa <br> ... |
|5| User may view a client's details <li>Click `All clients` in the navigation bar to locate a client's name</li> <li>You may also locate a client's name in the stylist's details view under 'client list'</li> | Click on 'Smith, Lisa'  | Lisa Smith <br> Stylist: Chris McMillan <br> Phone: 808-555-1234 <br> Email: lisa.smith@gmail.com  |
|6| User may update a client's first name, last name, phone number, email and stylist<li>Click on client's name</li> <li>View returns the client's details</li> <li>Enter updated information in 'Edit client details' form</li> <li>Click `Update`</li> | Currently: <br> Lisa Smith <br><br> Last Name: 'Ford' <br> Click `update` | 'Client Details' view: <br> Lisa Ford <br> ... |
|7| User may delete a client <li>Click on client's name</li> <li>View returns the client's details</li>  | Click `Delete client`  | Confirmation view: 'Client has been deleted'  |
|8| User may delete a stylist <li>Click on stylist's name</li> <li>View returns the stylist's details</li> <li>Click `edit`</li> View returns 'Edit Stylist Details'</li> | Click `Delete stylist`  | Confirmation view: 'Stylist has been deleted'  |
|9| User may update a stylist's first name, last name, pricing for women's and men's hair cuts <li>Click stylist's button</li> <li>View returns 'Stylist Details'</li> <li>Click `edit`</li> <li>View returns 'Edit Stylist Details' with form to update the stylist's information | Currently: <br> Men's Cut $40 <br> <br> Men's Cut $ '45' <br> Click `update`  | 'Stylist Details' view: <br> ... <br> Men's Cut $45 <br> ...  |




## Setup/Installation Requirements

* _Download and install [.NET Core 1.1 SDK](https://www.microsoft.com/net/download/core)_
* _Download and install [Mono](http://www.mono-project.com/download/)_
* _Download and install [MAMP](https://www.mamp.info/en/)_
* _Set MySQL Port to 3306_
* _Clone repository_

#### There are two options to create the database:
##### 1. In MySQL
`> CREATE DATABASE travel_blog;`<br>
`> USE travel_blog;`<br>
`> CREATE TABLE locations (id serial PRIMARY KEY, country VARCHAR(255), city VARCHAR(255));`<br>
`> CREATE TABLE experiences (id serial PRIMARY KEY, title VARCHAR(255), story TEXT, location_id INT );`<br>
`> CREATE TABLE people (id serial PRIMARY KEY, name VARCHAR(255), experience_id INT );`
##### 2. Import from the Cloned Repository
* _Click 'Open start page' in MAMP_
* _Under 'Tools', select 'phpMyAdmin'_
* _Click 'Import' tab_
* _Choose database file (from cloned repository folder)_
* _Click 'Go'_

## Technologies Used
* _C#_
* _.NET_
* _MVC_
* _Entity Framework_
* _[Bootstrap](http://getbootstrap.com/getting-started/)_
* _[MySQL](https://www.mysql.com/)_

### License

Copyright (c) 2017 **_Kaili Nishihira and Michael Woldemedihin**

*Licensed under the [MIT License](https://opensource.org/licenses/MIT)*
