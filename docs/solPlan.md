SinglePlayer prtotype 1:
* Menu
    [] singlePlayer button
    [] exit button
* Game configuration (choose level, etc)
    [] start button 
* Pre-game
    [] I'm ready button
* Level info
    [] level description
    [] ready button
* Game
    * Gameplay
        [] hero - square - just exist on some place
        [] enimy - circle - appeared by data from json
        enemies are moving with constant speed If they reach hero level is failed 
    * Interface:
        [] enemy could be focused (highlighted)
        [] when enemy highlighted we see question and input for answer
        [] after pressing enter input data compared with Enemy.answer and if they are equal enemy desappeared
        [] level progress bar
        [] when level completed -> go to the Level passed page
* Level Passed
    [] text
    [] go to the next level button
    [] go to the menu button

World
    id: string
    name: string
    description: string
    levels: Level[] @sorted

Level
    id: string 
    title: string
    description: string
    waves: Wave[] @sorted

Wave
    id: string
    delayTime: integer
    enemies: Enemy[]

Enemy
    id: string
    question: string
    answer: string
    type: EnemyType

enum EnemyType
    circle
    
Previous version
--------------------------------------
1. auth (back)
2. auth (front)
3. websocket-server 
4. front with only one shared text-area
5. database (ability to save chat)
6. questions from server
7. scores
8. rooms for users
9. add few levels for current world of questions
10. add more worlds
11. design
12. docker
13. deploy web (heroku)
14. multiplatform
