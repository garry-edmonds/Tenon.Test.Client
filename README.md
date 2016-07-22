# Tenon.Test.Client

This project works with the accessibility tool from <a href="http://Tenon.IO">Tenon.IO</a> using their API.
You will need to register an account at the following URL to use it <a href="https://tenon.io/register.php">Register Here</a> 
once registered you can test the website by sending the URL of the page or the html page source.

## How to use Tenon.Test.Client.
Project will be available as a nuget package at http://nuget.org.

##Create an instance of the test class:

1 - Create instance using URL:

- `TenonIO tenon = new TenonIO(<APIKEY>, new Uri(<URL-TO-TEST>));

2 - Create instance using Page Source:

- `TenonIO tenon = new TenonIO(<APIKEY>, <STRING-OF-HTML-SOURCE>);

##Running the test:
There are two choices for the output that is generated from the accessibility test.

1 - Return output as Json string of data.

string json = tenon.ExecuteTestJson();

2 - Return output as an object.

ApiResponse response = tenon.ExecuteTest();

## Optional Parameters.
To see a full list of all the optional parameters go to <a href="https://tenon.io/documentation/understanding-request-parameters.php">parameters<a/>.

To set these parameters.  

tenon.SetCertainty(Certainty.Sixty);  etc.


## Building the Package
* Clone this repository to your local file system
* Open the soloution in Visual studio 2015 and build
