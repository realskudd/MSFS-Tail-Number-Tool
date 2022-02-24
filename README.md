# MSFS-Tail-Number-Tool
A simple utility to change the tail number on an aircraft after a flight has been started.

I got tired of forgetting to change my tail number after a flight started to match what the economy I was using had. It got really annoying having to do this for every flight,
especially when I was renting other aircraft.

This tool uses [FSUIPC7](http://www.fsuipc.com/) to set the tail number.

## Requirements
* FSUIPC7
* Microsoft Flight Simulator 2020

## Important Notes
I have found that this works best if it's used before the "Fly Now" button is clicked after the sim loads. By that, I mean after you load your flight plan or select your departure/arrival/route, when the environment is loaded and you are in your aircraft.

It might take a few minutes for the tail number to be updated in the sim. Some testers have reported that the label on the dash updates immediately but the tail number doesn't. Others have said that it doesn't happen for a few minutes.

If you forget about it and have already started flying and talking to ATC, you'll find that the controllers don't know that your tail number changed and will keep talking to you on your old tail number.

One final note of caution: Sometimes when I have left the application running and exited the simulator, the simulator was stuck until I closed this application. It's not a consistent and reproducable thing, but it does happen.


## Credits
First and foremost I want to thank Pete & John Dowson for making FSUIPC. I have had so much headache trying to get SimConnect SDKs working, but FSUIPC works as expected on the first try.

Also, I want to thank the [FSE](https://www.fseconomy.net/) for expressing interest in a utility like this. Had they not, I would have probably just sat on this in my own messy project files. :)

## Other things
I'm not asking you to pay me for this in any fashion, that would go against the whole point of open source software. However, if you would like to donate something to me, you can!

[Buy me a coffee!](https://www.buymeacoffee.com/skudd)

If you're on FSE, you can also send some in-game money to me; my username in there is `skudd`
