# SinglePlayer

## v0.6
* [] find designer
* [] find tester
* [] fix bugs
* [] front: update styles

## v0.5
* [] front: authorization (if user want to save progress)
* [] back: save user progress, statistic
* [] front: load user progress, statistic
* [] back: adjust deployment
* [] fron: about us page (mission, contributors, donations, feedback mail)

## v0.4
* [] back: multiplayer service
* [] front: join page
* [] front: create host page (update game configuration page)
* [] front: multiplayer - update game page
* [] front: multiplayer - update pre game page

## v0.3
* [x] back: static server query
* [] back: static server command
* [] back: crud for the whole world (+ relation world-user)
* [] front: crud for entities (full create world)
* [] front: update main page (go to the editor button)

## v0.2
* [] front: Game configuration
* [] front: load world from back
* [x] front: get world endpoint 
* [x] front: openapi generation
* [x] front: admin panel for db

## v0.1:
#### front: Menu page
* [x] singlePlayer button
* [x] exit button
#### Game configuration (choose level, etc)
* [] start button 
#### Pre-game
* [] add I'm ready button
#### Level info
* [] level description
* [] ready button
#### Game screen
##### Gameplay
* [x] hero - square - just exist on some place
* [x] enimy - circle - appeared by data from json
* [x] enemies are moving with constant speed
* [x] if they reach hero level is failed
* [] if failed -> move to the fail screen
##### Interface:
* [x] enemy could be focused (highlighted) by mouse
* [] enemy could be focused (highlighted) by tab
* [] enemy should be highlighted when focused
* [x] when enemy captured we see question and input for answer
* [] auto focus to input on capture enemy
* [] after pressing enter input data compared with Enemy.answer and if they are equal enemy desappeared
* [] level progress bar
* [] when level completed -> go to the Level passed page
#### Level Passed
* [] text
* [] go to the next level button
* [] go to the menu button
#### Level failed
* [] text
* [] go to pre game page button
* [] go to menu button
