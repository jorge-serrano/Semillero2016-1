def ReadTxt(file, procces):
    current_file = open(file,"r")
    reader_file = current_file.read()
    current_file.close()
    l = []
    count = 0
    for element in reader_file.split("\n"):  
        if element.split(",") in l and procces == 1:
            count = count + 1
        else:
            l.append(element.split(","))
    return l, count