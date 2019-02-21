# Swedish recycling station component
This custom component checks the recycling station (återvinningsstation). 
Check https://www.ftiab.se/173.html to search for your specifc recycling station. You will need the unique id of the station when configuring the component.

## Usage
Copy the `swedish_recycling.py` to your folder `custom_component/sensor` folder under config root

The component will create a sensor with the state of the value you shoose in `use_as_state`. The rest of the properties will show as attributes in the sensor. You can only choose one of the options as state in `use_as_state`

## Configuration
```yaml
sensor:
  - platform: swedish_recycling
    entities:                           
      matfors:                        # name of entity
          station_id: '10421'         # unique station id
          use_as_state: 'NextCarton'  # what to display as state, can only choose one here
```
|property|description|
|---|---|
|station_id|unique id, please se [here](https://www.ftiab.se/173.html) to find the id of your station
|use_as_state|**Use one of the following:** LastCleaning, NextCleaning, LastColoredGlass, NextColoredGlass, LastGlass, NextGlass, LastCarton, NextCarton, LastMetal, NextMetal, LastPlastic, NextPlastic, LastPapers, NextPapers
|   |   |

