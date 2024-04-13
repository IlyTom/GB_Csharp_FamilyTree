
using FamilyTree;

var grandFather = new AdultFamilyMember() { Mother = null, Name = "Василий", Father = null};
var fatherOne = new AdultFamilyMember() { Mother = null, Name = "Иван", Father = grandFather};
var motherOne = new AdultFamilyMember() { Mother = null, Father = null, Name = "Мария" };
var fatherTwo = new AdultFamilyMember() { Mother = null, Name = "Cергей", Father = grandFather };
var motherTwo = new AdultFamilyMember() { Mother = null, Father = null, Name = "Василиса" };

grandFather.Children = new FamilyMember[] { fatherOne, fatherTwo };

var sonOne1 = new FamilyMember() {Father = fatherOne, Mother = motherOne, Name = "Кирилл"};
var sonOne2 = new FamilyMember() { Father = fatherOne, Mother = motherOne, Name = "Илья" };
var sonOne3 = new FamilyMember() { Father = fatherOne, Mother = motherOne, Name = "Андрей" };

var sonTwo1 = new FamilyMember() { Father = fatherTwo, Mother = motherTwo, Name = "Алексей" };
var sonTwo2 = new FamilyMember() { Father = fatherTwo, Mother = motherTwo, Name = "Владислав" };
var daughterTwo = new FamilyMember() { Father = fatherTwo, Mother = motherTwo, Name = "Алена" };

fatherOne.Spouse = motherOne;
motherOne.Spouse = fatherOne;

fatherTwo.Spouse = motherTwo;
motherTwo.Spouse= fatherTwo;

fatherOne.Children = new FamilyMember[] { sonOne1, sonOne2, sonOne3 };
motherOne.Children = new FamilyMember[] { sonOne1, sonOne2, sonOne3 };

fatherTwo.Children = new FamilyMember[] { sonTwo1, sonTwo2, daughterTwo };
motherTwo.Children = new FamilyMember[] { sonTwo1, sonTwo2, daughterTwo };



grandFather.Print(5);
Console.ReadLine();