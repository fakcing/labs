from datetime import datetime, timedelta

class Reis:
    def __init__(self, number, date, departure, arrival, time_out, time_in):
        self.number = number
        self.date = date
        self.departure = departure
        self.arrival = arrival
        self.time_out = time_out
        self.time_in = time_in

    def duration(self):
        t1 = datetime.strptime(self.time_out, "%H:%M")
        t2 = datetime.strptime(self.time_in, "%H:%M")
        d = t2 - t1
        if d.days < 0:
            d = timedelta(days=1) + d
        return d

    def time_since_end(self):
        now = datetime.now()
        end = datetime.strptime(self.date + " " + self.time_in, "%Y-%m-%d %H:%M")
        return now - end

    def info(self):
        print("Рейс №", self.number)
        print("Маршрут:", self.departure, "->", self.arrival)
        print("Час виїзду:", self.time_out, "Час прибуття:", self.time_in)
        print("Тривалість:", self.duration())
        print("--------------------------")
