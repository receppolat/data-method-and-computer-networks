def subnetHesapla(IP):
    if IP >= 1 and IP <= 126:
        return 1
    elif IP >= 128 and IP <= 191:
        return 2
    elif IP >= 192 and IP <= 223:
        return 3
    elif IP >= 224 and IP <= 255:
        return 4
    else:
        return -1

def agHesapla(IP):
    sub = ""
    subnetMask = ""
    agAdresi = ""
    gateway = ""
    broudcast = ""
    sayac = 0
    for i in range(len(IP)):
        if IP[i] != '.':
            sub += IP[i]
        else:
            break
    kontrol = subnetHesapla((int)(sub))
    for i in range(len(IP)):
        gateway += IP[i]
        broudcast += IP[i]
        if IP[i] == '.':
            sayac += 1
        if sayac == 3:
            gateway += "1"
            broudcast += "255"
            break
    sayac = 0
    if kontrol != -1:
        for i in range(len(IP)):
            agAdresi += IP[i]
            if IP[i] == '.':
                sayac += 1
                if kontrol == 1:
                    agAdresi += "0.0.0"
                    subnetMask = "255.0.0.0"
                    break
                elif kontrol == 2 and sayac == 2:
                    agAdresi += "0.0"
                    subnetMask = "255.255.0.0"
                    break
                elif kontrol == 3 and sayac == 3:
                    agAdresi += "0"
                    subnetMask = "255.255.255.0"
                    break
                elif kontrol == 4 and sayac == 3:
                    agAdresi = IP
                    subnetMask = "255.255.255.255"
                    break
        print("IP Adresi: ",IP)
        print("Bulunduğu Ağ Adresi: ",agAdresi)
        print("Subnet Mask: ",subnetMask)
        print("Gateway Adresi: ",gateway)
        print("Broudcast Adresi: ",broudcast)
    else:
        print("Böyle bir IP adresi mevcut olamaz.")
        
ip = input("IP Adresini giriniz..(ORN: 192.168.1.2): ")
agHesapla(ip)