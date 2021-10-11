
export class Order {
    Id!: number;
    ShippedDate!: Date;
    ShipVia!: string;
    ShipName!: string;
    Address!: string;
    City!: string;
    Country!: string;
}

export class Shippers {
    ShipperId!: number;
    CompanyName!: string;
    Phone!: string;
  }
