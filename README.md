# Tournament Tracker

### Scenario
Create a bracket tournament system where the program indicates who to play in a single-elimination style bracket. 
At the end, the winner should be identified. 
Modelled against the NCAA Basketball tournament bracket style.

### Requirements
1. Track games played and their outcome(who won).
2. Multiple competitors play in the tournament. 
3. Create a tournament plan(who plays in what order)
4. Schedule games.
5. Single loss eliminates player.
6. The last player standing is the winner.

### Questions
1. How many players will the tournament handle? Fixed or variable?
    * application should be able to handle a variable number of players in the tournament.

2. If a tournament has less than the full complement of players, how do we handle it?
    * a tournament with less than the perfect number(an even number) should add in byes. basically certain people selected at random get to skp the first round and act as if they won.

3. Should the ordering of who plays each other be random or ordered by input order?
    * the ordering should be random
    
4. Should we schedule the game or are they just played spontaneously?
    * the games should be pplayed in whatever order and whenver the players want to play them.

5. If the games are scheduled, how does the system know when to schedule the games for?
    * they're not scheduled.

6. If the games are played whenever, can a game from the second round be played before the first round is complete?
    * no. each round should be fully completed before the next round is displayed.

7. Does the system need to store the score of some kind or just who won?
    * storing the simple score would be nice. just a number for each player. that way, a tracker can be flexible enough to handle a checkers tournament(the winner should have a 1 and the loser a 0) or a basketball tournament.

8. What type of front-end should this program have? (form, webpage, app etc)?
    * the system should be a desktop program for now, but down the road we might want to turn it into an app or website.

9. Where will the data be stored?
    * ideally the data should be stored in msql with an option to store it locally on a text file.

10. Will the system handle entry fees, prizes or other payouts?
    * tournament should have an option of charging an entry fee. prizes should also be an option, where the tournament administrator chooses how much money to award a variable number of places. the total cash amount should not exceed the income from the tournament. a percentage-based system would also be nice to specify. 

11. What type of reporting is needed?
    * A simple reporting system specifying the outcome of the games per round as well as a report that specifies who won and how much they won. these can be just displayed on a form or they can be emailed to tournament competitors  and the administrator.
    
12. Who can fill in the results of the game?
    * anyone using the application should be able to fill in the forms.
    
13. Are there varying levels of access? admin vs local vs guest etc
    * no. the only method of varied access is if the competitors are not allowedinto the application and instead, they do everything via email.

14. Should this system contact users about upcoming games?
    * yes, the system should email users that they are due to play in a round as well as who they are scheduled to play. 

15. Is each player on their own or can teams use this tournament tracker?
    * program should be able to handle the addition of other members. all members should be treated equal and can get tournament emails. teams should eb able to name their teams. 


### Big Picture Design
**Structure**: Windows Forms application and Class Library. 
**Data**: SQL and/or Text File.
**Users**: One at a time on one application.

**Key Concepts**:
* Email
* SQL
* Custom Events
* Error Handling
* Interfaces
* Random Ordering
* Texting

## subheader
this is simply to test git commands and changes 
I am adding something else for testing 

