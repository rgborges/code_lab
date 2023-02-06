"use strict";
exports.__esModule = true;
exports.Person = void 0;
var Person = /** @class */ (function () {
    function Person(id, name) {
        this.id = id;
        this.name = name;
    }
    Person.prototype.say = function (message) {
        console.log('hi {message}');
    };
    return Person;
}());
exports.Person = Person;
