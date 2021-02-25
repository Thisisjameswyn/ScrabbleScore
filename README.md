## James Wyn

# Currency Exchange


### Description
This is my sixth week project for Epicodus.  The objective is to take a given currency value and convert to a selected country's value using current data retrieved from https://www.exchangerate-api.com/.  The form should allow for the selection of two countries and an amount to exchange, then return the converted value back to the user.

This program requires an API key which can be obtained here https://www.exchangerate-api.com/.  Once you have your key you can put it in the .env file as described in the instructions. 

### Technologies Used
* Bootstrap
* JavaScript
* jQuery
* JSON
* HTML
* CSS
* MD

## Setup/Installation Requirements

### Without Github template clone:
* Clone Repo
* Delete .git if needing a clean commit history
* Initilize git
* Add remote repository to new git
* Create a file called .env in the top level of the directory
* Make first commit only adding .gitignore to commit
* Inside the .env file place the following line of code: API_KEY=[Your API key goes here without brackets]
* Open new repo to begin npm initilization

### With Github
* Press use this template
* Create new repo
* Clone new repo down to
* Open new repo to begin npm initilization

### Npm Initilization
* Verify package.json has correct npm packages for needs
* Modify title on line 18 of webpack.config.js
* Modify title on line 2 of package.json
* Modify description on line 19 of package.json
* Modify title on line 2 if package-lock.json
* Run ```npm init -y```
* Run ```npm install```
* Verify install works by running ```npm run test``` and ```npm run build```

* * *

## Link where to find my GitHub link

*https://github.com/Thisisjameswyn/CurrencyExchanger


### Specs

* Describe: GalAge
Test: "should correctly construct an object with given age"
Expect(testAge.age).toEqual(50)

* Test: "should correctly construct an object with average age"
Expect(testAge.averageAge).toEqual(80)

* Test: "should correctly construct an object with an age and average age array"
Expect(testAge.ageArray).toEqual([50, 80])

* Describe: GalAge.getMerc()
Test: "should correctly convert given age and average age to mercury years"
Expect(testAge.getMerc()).toEqual([208, 333])

* Describe: GalAge.getVenus()
Test: "should correctly convert given age and average age to venus years"
Expect(testAge.getVenus()).toEqual([80, 129])

* Describe: GalAge.getMars()
Test: "should correctly convert given age and average age to mars years"
Expect(testAge.getMars()).toEqual([26, 42])

* Describe: GalAge.getJupiter()
Test: "should correctly convert given age and average age to jupiter years"
Expect(testAge.getJupiter()).toEqual([4, 6])

## License
[MIT License](https://opensource.org/licenses/MIT)
&copy; James Wyn 2021