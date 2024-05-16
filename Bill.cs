using System;

namespace Bar {
    class Bill {
        public char gender;
        public string beer;
        public string softDrink;
        public string barbecue;

        public decimal Feeding() {
            return this.beer * 5 + this.softDrink * 3 + this.barbecue * 7;
        }

        public decimal Couvert() {
            double fee = this.Feeding();
		if	(fee > 30.00) {
			return 0.00;
		}
		else {
			return 4.00;
		}
	}

        public decimal Ticket() {
            if (this.gender == 'F') {
			return 8.00;
		}
		else {
			return 10.00;
		}
	}

        public decimal Total() {
            return this.feeding() + this.cover() + this.ticket();
        }

        public Bill() {
		super();
	}
    }
}