# Custom component computer
This component combines wake-on-lan and the utility sleep-on-lan to make computers go on and off using a simple switch

To install sleep-on-lan on the computer you want to control, please see: https://github.com/SR-G/sleep-on-lan

## Configuration
```yaml
switch:
  - platform: computer
    entities:
      name1:
          mac: '14:30:2b:1f:39:2e'
          ip: '192.168.0.2'
      name2:
          mac: '64:d1:22:9f:34:1e'
          ip: '192.168.0.2'
```

