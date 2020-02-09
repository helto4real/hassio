DOMAIN = "netdaemon"

ATTR_CLASS = "class"
ATTR_METHOD = "method"

# SERVICE_ADD_URL_SCHEMA = vol.Schema(
#     {vol.Required(CONF_NAME): cv.string, vol.Required(CONF_URL): cv.url}
# )


async def async_setup(hass, config):
    async def handle_register_service(call):
        """ Handles the service call """

        daemon_class = call.data.get(ATTR_CLASS, "no class provided")
        daemon_method = call.data.get(ATTR_METHOD, "no method provided")

        print("Register service {}_{}".format(daemon_class, daemon_method))
        hass.services.async_register(
            DOMAIN, "{}_{}".format(daemon_class, daemon_method), handle_class_methodcall
        )
        #  hass.states.async_set("hello_service.hello", name)

    async def handle_class_methodcall(call):
        """ Handle the class method call """
        # Do nothing for now, the netdaemon intersects

    hass.states.async_set("hello_state.world", "Paulus")

    hass.services.async_register(DOMAIN, "register_service", handle_register_service)
    # Return boolean to indicate that initialization was successful.
    return True
