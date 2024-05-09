using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Licenta.Formulare
{
    public class AllBooks
    {

        // matrice 


         public  BookClass[] book { get; set; }
        public AllBooks()
        {
       
        }

        public void Book()
        {
           book =  new BookClass[32];
            // books in en
            book[0] = new BookClass("Our Reluctant Man in Berlin", "Ken Donald");
            book[1] = new BookClass("The Hunger Games ", "Suzanne Collins");
            book[2] = new BookClass("Ender's Game ", "Orson Scott");
            book[3] = new BookClass("The Battle of the Labyrinth ", "Rick Riordan");
            book[4] = new BookClass("The Bourne Identity", "Robert Ludlum");
            book[5] = new BookClass("Jurassic Park", "Michael Crichton");
            book[6] = new BookClass("Oliver Twist", "Charles Dickens");
            book[7] = new BookClass("Allegiant", "Veronica Roth");

            book[8] = new BookClass("A Brief History of Time", "Stephen Hawking");
            book[9] = new BookClass("Fundamentals of Computer Programming with C#", "S.Nakov");
            book[10] = new BookClass("Theory of Everything", "Fran De Aquino");
            book[11] = new BookClass("SQL for Dummies ", "Allen G Taylor");
            book[12] = new BookClass("The Maths E-book of Notes", "MR Barton");
            book[13] = new BookClass("ARDUINO for BEGINNERS","John Baichal");
            book[14] =  new BookClass("Introduction to Logic Programming ", "Ronald J. Brachman");
            book[15] = new BookClass("Learning C# by Developing Games with Unity 3D..", "Terry Norton");

            book[16] = new BookClass("Thought and Language", "Lev Vygotsky");
            book[17] = new BookClass("The Art of Loving ", "Erich Fromm");
            book[18] = new BookClass("The Ego and the Mechanisms of Defence ", "Anna Freud");
            book[19] = new BookClass("Self Analysis", "Horney Karen");
            book[20] = new BookClass("The Psychology of The Child ", "Jean Piaget");
            book[21] = new BookClass("Childhood and Society ","Erik Erikson");
            book[22] = new BookClass("A General Introduction to Psychoanalysis","Sigmund Freud");
            book[23] = new BookClass("Introduction to Psychology", "-");

            //carti in romana 
            book[24] = new BookClass("Evadare tacuta", "Lena Constante");
            book[25] = new BookClass("Ochii timpului", "George Sovu");
            book[27] = new BookClass("Misterele fluviului", "Dennis Lehane");
            book[28] = new BookClass("Refugiul de la Stillhouse Lake", "Rachel Caine");
            book[29] = new BookClass("Codul lui Da Vinci", "Dan Brown");
            book[30] = new BookClass("Mentorul", "Steve Jackson");
            book[31] = new BookClass("Locuri întunecate", "Gillian Flynn");
            book[32] = new BookClass("Fortăreața digitală", "Dan Brown");

            book[33] = new BookClass("Manual C++ "," _");
            book[34] = new BookClass("Analiza matematica ", "Grecu Luminita ");//*
            book[35] = new BookClass("Geometrie Diferentiala", "Mircea Crasmareanu ");//*
            book[36] = new BookClass("MATLAB Un prim pas spre cercetare", "Catalina Neghina ");
            book[37] = new BookClass("Fundamente de inginerie mecanica","Daniel Parvulescu");
            book[38] = new BookClass("Manualul electricianului", "_");
            book[39] = new BookClass( "Analiza matematica in complex  ", "Delia Maria Kerkes ");
            book[40] = new BookClass("Funcții Criptografice..." , "Bogdan Groza");

            book[41] = new BookClass("Formula fericirii", "Stefan Klein");
            book[42] = new BookClass("Niciodată nu e de ajuns", "Judith Grisel");
            book[43] = new BookClass("Dementa digitala", "Manfred Spitzer");
            book[44] = new BookClass("Cum sa invingi grijile si stresul", "Dale Carnegie");
            book[45] = new BookClass("O educatie emoționala", "Alain de Botton"); 
            book[46] = new BookClass("Tehnici de Eliberare Emotionala", "Gary Craig");
            book[47] = new BookClass("Puterea extraordinara a subconstientului tau", "Joseph Murphy");
            book[48] = new BookClass("Umbra din noi Forta vitala subversiva", "Verena Kast");

        }

    }






}

