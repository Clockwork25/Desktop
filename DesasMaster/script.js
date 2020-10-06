//izvada button konsolee, tad kad atrod elementu button
// console.log(button);

//izvada button konolē, tad kad atrod elementu pēc indeksa norādits ar [1]
// console.log(button[1]);

//izvada elementa kārtas skaitli
// console.log(buttons.lenght);

// for (let i = 0; i<= button.length; i++){
//     console.log(button[i]);
// }

// No visām pogām pēdējā uz klišķa darbības tiek pielikts teksts
// for (button of button){
//     button.addEventListener
//     (
//         "click", function ()
//         {
//             button.textContent="x";
//         }
//     );
// }

/////////////////////////////////////////////////////

/*
for (button of button){

    button.addEventListener
    (
        "click", function ()
        {
 //         Šis nozīmē, ka tas elements uz kura uzklikšķina, uz to parādīsies teksts
             this.textContent="x";
        }
    );
}
*/

/////////////////////////////////////////////////////
//Tas pats kas iepriekšējais, tikai funkcija ir atdalīta atsevišķa blokā

/*
for (button of button){

    button.addEventListener
    (
        "click", abcdefg()
    );
}

function abcdefg()
        {
 //         Šis nozīmē, ka tas elements uz kura uzklikšķina, uz to parādīsies teksts
             this.textContent="x";
    
        }
*/
///////////////////////////////////////////////////

//Index.html jāaizviet pirmā poga ar linku <a href="#button"></a>

/*
for (button of buttons){

    button.addEventListener
    (
        "click", function ()
        {
            // preventDefault tiek pielikts, lai links uz kuru html tiek uzrakstīts nearādās browsera adrešu laukumā
            event.preventDefault();
 //         Šis nozīmē, ka tas elements uz kura uzklikšķina, uz to parādīsies teksts
             this.textContent="x";
        }
    );
}
*/

////////////////////////////////////////////////////
//Pēdējais variants pirms jQuery
/*

let buttons = document.querySelectorAll("#tic-tac-toe button");

let symbol = "x";

for (button of buttons){

    button.addEventListener
    (
        "click", function()
        {
            if (this.textContent != "") {    
                return;
            }
                this.textContent= symbol;
                //pamīšus mainoši simboli, lai būtu x un pēc tam 0.
                if (symbol == 'x'){
                symbol = '0';
                }
                else {
                symbol = 'x';
                }
 //             Šis nozīmē, ka tas elements uz kura uzklikšķina, uz to parādīsies teksts
            
        }
    );
}

document.getElementById("reset").addEventListener("click", function() {

   for (button of buttons){
       button.textContent = "";
   }

});
*/
let symbol = "X";
let game_frame = $('#game-window');
console.log(game_frame + "Test: OK");

game_frame.find("button").click(function(){
    
    //html veids
    //this.textContent = "x";
    
    //jQuery veids
    //$(this).text("x");

   // Var arī ievietot html kodu atvērtā browserī !!!
if ($(this).html() == "")

    $(this).html(`<strong>${symbol}</strong>`);
    if (symbol == "X"){
        symbol = "O"
    }
    else {
        symbol = "X";   
    }
});