import pandas as pd
import csv


data = pd.read_csv("country_code.csv")

country_code = data['alpha-2']
countries = data['name']

country_with_country_code = dict(zip(country_code, countries))

