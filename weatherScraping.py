import urllib.request
import json
import datetime
from country_code_df import country_with_country_code as cc_dict
from cityClass import City

def search_city():
    search = True
    while(search==True):
        city = input("\nType a city to search for: ")
        API_Key = "4835cc6a727ba8d950f6866e7a7d287d"

        URL = "http://api.openweathermap.org/data/2.5/weather?q=%s&APPID=%s" % (city, API_Key)

        try:
            json_string = urllib.request.urlopen(URL).read()
            search = False
            return json_string
            
        except:
            print("\nCity not found. Have you checked your spelling?!")
            
        
def city_info(json_string):

    #print(json_string)
    #{"coord":{"lon":5.54,"lat":51.61},
    # "weather":[{"id":800,"main":"Clear","description":"clear sky","icon":"01n"}],
    # "base":"stations",
    # "main":{"temp":283.32,"pressure":1027,"humidity":81,"temp_min":282.15,"temp_max":284.15},
    # "visibility":10000,
    # "wind":{"speed":1.5,"deg":260},
    # "clouds":{"all":0},
    # "dt":1538592900,
    # "sys":{"type":1,"id":5219,"message":0.0092,"country":"NL","sunrise":1538545374,"sunset":1538586566},
    # "id":2745726,
    # "name":"Veghel",
    # "cod":200}'

    json_string = json_string
    time = datetime.datetime.now().strftime("%H:%M:%S %d-%m-%Y")
    city_dict = json.loads(json_string)

    def get_name():
        return city_dict["name"]

    def get_country():
        code = city_dict["sys"]["country"]
        return cc_dict[str(code)]

    def kelvin_to_celsius(kelvin):
        celsius = kelvin-273.15
        return celsius

    def get_temperature():
        kelvin = city_dict["main"]["temp"]
        celsius = round(kelvin_to_celsius(kelvin),1)
        return "%d C˚" % (celsius)

    newCity = City(name=get_name(), country=get_country(), datetime=time, temperature=get_temperature())
    general_city_info = "%s - %s, %s on %s" % (newCity._Name, newCity._Country, newCity._Temperature, newCity._Datetime)

    choices = { "country" : newCity._Country,
                "temperature" : newCity._Temperature,
                "general" : general_city_info}
    
    while(True):
        choice = input("\n Commands: \n\n Country \n Temperature \n  General \n \n").lower()
        try:
            print(choices[choice])
            break
        except:
            print("\nNot a valid command. Please try again!")
            



# Main program
lets_go_again = True
while(lets_go_again == True):
    city_searched = search_city()
    city_info(city_searched)

    while(True):
        response = input("Do you want to continue? Yes or no?\n").lower()
        if response == "yes":
            break
        elif response == "no":
            lets_go_again = False
            break
        else:
            print("Command invalid. Please choose yes or no!")
    
    