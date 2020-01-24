def get_yr_weather_text_from_symbol(symbol: int) -> str:
    if symbol == '1':
        return "vackert och klart väder"
    elif symbol == '2':
        return "vackert väder med lätt molninghet"
    elif symbol == '3':
        return "delvis molnigt väder"
    elif symbol == '4':
        return "molnigt väder"
    elif symbol == '5':
        return "sol med regnbyar"
    elif symbol == '6':
        return "regnbyar med inslag av åska"
    elif symbol == '7':
        return "byar med snöblandat regn"
    elif symbol == '8':
        return "sol med snöbyar"
    elif symbol == '9':
        return "ihållande regn"
    elif symbol == '10':
        return "kraftigt ihållande regn"
    elif symbol == '11':
        return "kraftigt ihållande regn och åska"
    elif symbol == '12':
        return "ihållande snöblandat regn"
    elif symbol == '13':
        return "snö"
    elif symbol == '14':
        return "snö och åska, så konstigt va"
    elif symbol == '15':
        return "dimma så var försiktig"
    elif symbol == '20':
        return "byar av snöblandad regn och åska"
    elif symbol == '21':
        return "Snöbyar med inslag av åska"
    elif symbol == '22':
        return "Regn med blixtar och åska"
    elif symbol > '22' and symbol < '35':
        return "tokväder med åska, nederbörd"
    elif symbol > '39' and symbol < '50':
        return "tokväder med snö"
    elif symbol == '50':
        return "kraftigt snöfall, var försiktig och stanna hemma om du kan"
    else:
        return "Känner inte igen symbolen!"
