
export class Person {
  id : Number;
  name : String;

 constructor(id: Number, name: String) {
    this.id = id;
    this.name = name;
  }

  say (message : String) {
    console.log('hi {message}');
  }
}

