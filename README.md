# Hero's Journey generator

## About this project

This is a C# console application that generates the 12 steps of Vogler's version
of the Hero's Journey. Developed as the Final Project for cs50.

## How to use

After pulling the files from the project you had to be sure to have the Objects.txt, People.txt,
Places.txt and Verb.txt in order to the program to run correctly. After checking the files you
can open the project in your IDE to run the program.

The Menu accepts letters as input. To run the program just type 'c', then keep pressing any key to read each of the 12 step of the Hero's Journey that will be generate for you. If you, somehow, got
this project from another source, you can find you github repository typing the letter 's' in the
menu. It will give you the link for our repository.

There is also 'e' to exit.

## Adding new words in Files.

### Adding Objects

To add new words as Objects you should create a new line in Objects.txt and just write it down. 
Note: using upper case will affect the articles used in the program.

### Adding People

To add new Actors/people/animals/living beings just add a new line in People.txt with the name of the living being written in it.
Note: using upper and lower case will affect the article that the word will receive. So I suggest to use Upper case for names and lower case for animals or other things.
You can always check the names that are already in the file to see examples.

### Adding Places 

Just add a new line in Places.txt with the new place you want to add written in it. 
Note: upper and lower case will affect the article used inside the program.

### Adding Verbs

Verbs are quite different. To create a new verb you should add a new line in Verbs.txt with the verb written in it. 
Then, using comas ',' you must add one type of word that this verb needs to make sense.

Ex. New verb I want to add: throw
In the Verb.txt I should write: "throw,object"

Note: you should write using only ',' to separate the words. DO NOT USE SPACES

The types of words that are implemented so you can use as argument to the verb are:

 -object
 -place
 -living
 -verb

Which of these words will tell the program to use one random word from the Object.txt, Places.txt, People.txt and Verbs.txt files respectively.

Note: Some verbs needs two arguments (Ex. give). So you need to write two arguments (something that is given and someone that receives).
In the Verb.txt you should write: "give,object,living".

These are the basic of adding verbs. You can also add the same verb with differents arguments (Ex."throw,object" and "throw,living").
And you can also write verbs that needs another verb (Ex."help,living,verb" helping someone to do something).

## Feel free to use this code

As a project from a beginner and non-native english speaker, this project sure have a lot of parts that could be improved. 
So, if you want to use/adapt this code feel free to fork.