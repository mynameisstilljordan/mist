using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThoughtHolderScript : MonoBehaviour {
    [SerializeField]
    string[] thoughts = new string[] {
    "This is the start of your shower thought journey.  Hopefully this app will dismantle your understanding of ordinary everyday concepts and help you to see the world in a new light.\n-Totem :)",
    "Reading is basically the act of looking at marked slices of wood while vividly hallucinating.\n-Anonymous",
    "We advocate not judging a book by its cover; but also glorify 'love at first sight'.\n-u/spiritofmen",
    "Mistakes make you smarter. Yet after you make one, you are treated as if you were dumber.\n-u/boredsans",
    "Lawyers hope you get sued, doctors hope you get sick, cops hope you're criminal, mechanics hope you have car trouble, but only a thief wishes prosperity for you.\n-u/lastlived1",
    "The Olympics should have a 'For Fun' section at the end of all the games so all the athletes can try different sports.\n-u/dublzz",
    "Tall people are expected to use their reach to help shorter people, but if a tall person were to ask a short person to hand them something they dropped on the floor it'd be insulting.\n-u/HairlessHippie",
    "I've woken up over 10,000 times and I'm still not used to it.\n-u/dankerinooo",
    "When a company offers me a better price after I cancel their subscription, they're just admitting they were overcharging me.\n-u/Rhythman",
    "Somewhere in the world, there is somebody with your dream job that hates going to work everyday.\n-u/EmailSoup",
    "'DO NOT TOUCH' would probably be a really unsettling thing to read in braille.\n-u/Air_Hellair",
    "Vehicles today can surf the web, link to your phone, stream music and videos, etc but they still can't perform a simple database lookup to tell you what the check engine light is on for.\n-u/dwarftosser77",
    "Last night my friend asked to use a USB port to charge his cigarette, but I was using it to charge my book. The future is stupid.\n-u/The_JayMo",
    "When people think about traveling to the past, they worry about accidentally changing the present, but no one in the present really thinks they can radically change the future.\n-u/kai1998",
    "There should be a millennial edition of Monopoly where you just walk round the board paying rent, never able to buy anything.\n-u/RonSwanson23",
    "Gyms should have memberships where your fee goes down based on how often you go.\n-u/drain65",
    "My dog [understands] several human words. I don’t understand any dog barks. He may be smarter than me.\n-u/RAYMOND_SCOTT",
    "I recognize click bait almost every time, but still want to know what that child celebrity looks like today.\n-u/jeego82",
    "Nothing is on fire, fire is on things.\n-u/GuitarPerson159",
    "If aliens come to earth, we have to explain why we made dozens of movies in which we fight and kill them.\n-u/sKnochenbrecher",
    "Every time a character dies on a TV show I just feel bad for the actor who pretty much just got fired in front of us.\n-u/Doctor_Colossus",
    "Cemeteries would be way more interesting if they put the cause of death on the headstone.\n-u/Drakqula",
    "Taxes are like a subscription to your Country that you can't cancel, no matter how bad the service gets.\n-u/Filer93",
    "Your dog doesn't know you can make mistakes. When you trip over him in the dark, he thinks you got up just to kick him in the head.\n-u/Throw13579",
    "Car horns should only be allowed to be in pitches C, E, and G, so whenever two people honk at the same time it will be in harmony and traffic jams will sound like symphonies.\n-u/bringbackseymour",
    "Christmas feels more like a deadline than a holiday.\n-Unknown",
    "A ton (2000LB) of people is literally 12 to 15 people.\n-u/CornfishPie",
    "What if time travel is possible, but we just haven't figured out how to do it yet?\n-u/timetraveler3000",
    "What if every person is the center of their own universe, and their reality is completely unique to them?\n-Unknown",
    "What if our minds are just computers, and when we die, our consciousness is transferred to a new body or machine?\n-Unknown",
    "Lights in videogames use real electricity.\n-Unknown",
    "Gummy worms have more bones than real worms do (because of the gelatin).\n-Unknown",
    "Your stomach thinks all potatoes are mashed\n-Unknown",
    "If time is money, ATMS are like time machines.\n-Unknown",
    "'Go to bed, you'll feel better in the morning' is the human version of 'Did you turn it off and turn it back on again?'\n-Unknown",
    "Maybe plants are really farming us, giving us oxygen until we eventually expire and turn into mulch which they can consume.\n-Unknown",
    "Theme parks can snap a crystal clear picture of you on a roller coaster at 70 mph, but bank cameras can't get a clear shot of a robber standing still.\n-Unknown",
    "Randomly hearing your favorite song on the radio is more satisfying than playing it directly from your phone.\n-Unknown",
    "If my calculator had a history, it would be more embarrassing than my browser history.\n-Unknown",
    "What if aliens have been visiting Earth for centuries, but they're just really good at hiding?\n-u/aliensarereal99",
    "As a kid my parents taught me to not believe everything I see on TV, now I have to teach them to not believe everything they see on social media.\n-Unknown",
    "If someone offered to pay for my food and rent for the next 18 years, I'd do anything they ask of me. But I complained every time I took the trash out while living at my parent's house.\n-Unknown",
    "Instead of colorizing photos, in 50 years we will be removing filters.\n-Unknown",
    "Aliens invaded the Moon on July 20th, 1969.\n-Unknown",
    "What if the universe is just one big simulation being run by a super advanced AI, and we're all just characters in the game?\n-u/jamesbondfan234",
    "What if our dreams are just glimpses into parallel universes where different versions of ourselves exist?\n-u/theskyisblue12",
    "People who are goodlooking but have terrible personalities are basically real life click baits.\n-Unknown",
    "If Google matched people up by their browsing history, it could be the greatest online dating website of all time.\n-Unknown",
    "Someone who says 'I'll be there in 6 minutes' will normally arrive before someone who says 'I will be there in 5 minutes'.\n-Unknown",
    "Delivery people will leave $900 worth of electronics on my porch without even knocking but I have to sign for a $10 pizza.\n-Unknown",
    "Earth is like a guy who knows exactly where to stand next to a bonfire.\n-Unknown",
    "What if every time we make a decision, the universe splits into a new reality where the opposite decision was made?\n-u/decisionmaker456",
    "What if our memories are just stories we tell ourselves, and the past is not necessarily how it really happened?\n-Unknown",
    "The Swiss must have been pretty confident in their chances of victory if they included a wine bottle corkscrew on their army knife.\n-Unknown",
    "April Fool's Day is the one day of the year when people critically evaluate news articles before accepting them as true.\n-Unknown",
    "History classes are only going to get longer and harder as time goes on.\n-Unknown",
    "1984-2000 seems a very long time compared to 2000-2016.\n-Unknown",
    "An 'unlimited minutes per month' phone plan really only gives you 44,640 minutes per month at best.\n-Unknown",
    "Humans are really bad at recharging, it takes about 8 hours charge for 16 hours of use.\n-Unknown",
    "What if we're all just characters in a video game and the real world is just the loading screen?\n-Unknown",
    "What if the universe is just a hologram, and everything we see and experience is just an illusion?\n-Unknown",
    "Scientists are adult kids stuck in the 'why?' phase.\n-Unknown",
    "Clapping is just hitting your hands together repeatedly because you like something.\n-Unknown",
    "When jogging, we put on special clothes so people don't think we are running from or to something.\n-Unknown",
    "In order to fall asleep, you have to pretend to be asleep.\n-Unknown",
    "When the older generations says this generation is terrible, they're really saying they sucked as parents.\n-Unknown",
    "Why do people say 'tuna fish' when they don't say 'beef mammal' or 'chicken bird'?\n-Unknown",
    "If a stranger insults me, I'll probably ignore it, as their opinion is meaningless. If a stranger compliments me, I'll probably treasure it, as their opinion is important.\n-Unknown",
    "The Japanese flag could actually be a pie chart of how much of Japan is Japan.\n-Unknown",
    "The sinking of the Titanic must have been a miracle to the lobsters in the kitchen.\n-Unknown",
    "Imagine how terrifying fire would be if it wasn't a light source.\n-Unknown",
    "There's probably a combination of actions that, if I performed them in the correct order, would make me a millionaire in a day. I just don't know what they are.\n-Unknown",
    "Using solar panels to power an air conditioning unit is like using the Sun's power against itself.\n-Unknown",
    "Bushing your teeth is the only time you clean your skeleton.\n-Unknown",
    "Dogs probably destroy shoes because they see humans put them on before they leave the house.\n-Unknown",
    "If I punch myself in the face and it hurts...does that make me weak or strong?\n-Unknown",
    "Using your old computer to search for a new device you’ll buy is like asking your PC to dig its own grave.\n-Unknown",
    "A pizza is a circle, it’s delivered in a square. And you cut it into triangles.\n-Unknown",
    "I wonder if my pet has chosen a name for me.\n-Unknown",
    "When a pregnant woman swims, she is a human submarine.\n-u/heavywafflezombie",
    "I wonder if there are any times on the clock that I have never seen.\n-u/h1ghdeaz",
    "If two people on opposite sides of the world each drop a piece of bread, the Earth briefly becomes a sandwich.\n-u/nklotz",
    "For most of human history, vehicles had automatic collision avoidance and could even take you home when you were sleeping. Then we got rid of horses.\n-u/arbaminim",
    "Most teenagers pull their phones out of their pockets to check the time. We are reverting to the era of pocket watches.\n-u/SirTickleTots",
    "If you view a bald eagle at the zoo, you are looking at the American symbol of freedom in captivity.\n-u/keytarin",
    "If I touch my phone in the right places, a pizza will show up at my front door.\n-u/drunk_bird",
    "We will never hear about the truly perfect crime.\n-u/Cleffer",
    "If we pop bubble wrap made in China, the air that comes out is from China.\n-u/Shadows4",
    "What if the lottery is an Institution to catch Time Travelers?\n-u/imverykind",
    "If job ads say 'must be fluent in [Spanish]' why don’t they post the entire ad in [Spanish], that way only genuinely fluent people could apply?\n-u/Scamwau",
    "When you close both eyes you see black, but when you close one you see nothing.\n-Unknown",
    "We could be in backgrounds of peoples favourite photos.\n-Unknown",
    "When you’re alone in a room, you’re the only person in the world who can see what you can.\n-Unknown",
    "Millions of people are doing the exact same thing as you are.\n-Unknown",
    "Millions of people are in synchronization with your breathing right now.\n-Unknown",
    "You can manually breathe, blink and swallow just by thinking about it.\n-Unknown",
    "You don’t own money, it’s just your turn with.\n-Unknown",
    "Our jaws can only bite upwards. So you can’t actually bite down.\n-Unknown",
    "How do we know what the actual time is? Who set the first clock?\n-Unknown",
    "When you count from one to two you skip an infinite amount of decimal numbers.\n-Unknown",
    "You’ll never know how many people are thinking of you right now.\n-Unknown",
    "There’s a different version of you in the minds of everyone who knows you.\n-Unknown",
    "Your 'first birthday' is actually your second birthday.\n-Unknown",
    "You can’t stand backwards on stairs.\n-Unknown",
    "Baby butterflies don’t exist.\n-Unknown",
    "Humans are the only species that pay to live.\n-Unknown",
    "We aren’t scared of the dark, we are scared of what could be hiding there.\n-Unknown",
    "Nobody knows how anyone actually feels or thinks.\n-Unknown",
    "'Live' is just 'evil' spelt backwards.\n-Unknown",
    "One day you are going to think of someone for the last time and never know.\n-Unknown",
    "Every broken clock is telling you when its battery died.\n-Unknown",
    "People who are larger have more skin. Making them skinnier.\n-Unknown",
    "We eat pizza from the inside out.\n-Unknown",
    "If everyone blinked in sync nobody would know that other people blinked.\n-Unknown",
    "If a liar tells you they are lying, are they lying or telling the truth?\n-Unknown",
    "If we never talked to strangers we would never have friends.\n-Unknown",
    "If no customer complains about a bulletproof vest, it’s either really good or really bad.\n-Unknown",
    "If your shirt isn’t tucked into your pants. Then your pants are tucked into your shirt.\n-Unknown",
    "Lobsters are mermaids to scorpions.\n-Unknown",
    "If there was an earthquake on another planet is it still an earthquake?\n-Unknown",
    "Why is it called a building if it’s already built?\n-Unknown",
    "Fire trucks are actually water trucks.\n-Unknown",
    "If humans can’t see air, can fish see water?\n-Unknown",
    "Being scared to check your bank account is the adult version of being scared to check your grades.\n-Unknown",
    "Being pulled over by the cops for speeding is like teachers telling you to not run in the hallways.\n-Unknown",
    "Licking the inside of a pipe might seem disgusting but drinking water from the same pipe seems fine.\n-Unknown",
    "When people pierce their baby's ears, they have decided that it's okay to harm their child for purely aesthetic reasons.\n-Unknown",
    "If you wear clothes with the brands logo on them, you’re basically paying to advertise for them.\n-Unknown",
    "After tea was discovered, a lot of people probably died trying to make similar drinks from leaves that turned out to be toxic\n-Unknown",
    "The fictional language spoken in The Sims is probably how English sounds to non-English speakers.\n-Unknown",
    "A scented candle store burning down would smell amazing\n-Unknown",
    "Cannibals would consider a vegan person ‘grass-fed’\n-Unknown",
    "If people had wings that could allow them to fly, most people would still be flightless. Most people can’t even do a pull up.\n-Unknown",
    "Vampires always have great hair, even though they can’t see themselves in a mirror.\n-Unknown",
    "All Lego characters are bald, they either wear wigs or head accessories to hide it\n-Unknown",
    "Some children don't get to eat at school but a prisoner eats 3 meals a day\n-Unknown",
    "Piranhas seemed like a way bigger problem when we were kids.\n-Unknown",
    "You'll live 24 hours a day for your whole life, except for your birth and death date\n-Unknown",
    "Given how rare it is, it's a little weird that February 29th isn't celebrated more.\n-Unknown",
    "Probably a lot of People were thought to be poisoned in history, while they were probably just allergic to something they ate.\n-Unknown",
    "A pregnant woman has 8 limbs an is, therefore, an arachnid.\n-Unknown",
    "Human beings are probably the only creatures in the world that find the smell of wood smoke to be pleasant.\n-Unknown",
    "Maybe nobody speaks Latin anymore because it's too easy to cast spells by accident.\n-Unknown",
    "A starfish can grow back its Limbs and also grow back its whole body from a limb. So if you buy one starfish and keep breaking its limbs, you'll have infinite starfish.\n-Unknown",
    "People who quit smoking get so much more credit than people who never started smoking in the first place.\n-Unknown",
    "Every letter in ‘rounded’ is rounded.\n-Unknown",
    "3 am is either late or early based on your lifestyle.\n-Unknown",
    "Technically, your alarm tone is your theme song as it starts every episode.\n-Unknown",
    "When people steal cars in a movie, the mirrors and seat are always set perfectly for the thief.\n-Unknown",
    "Refined sugar is one of the most addictive and dangerous drugs in history.\n-Unknown",
    "The most dangerous world record to attempt to break is World’s Oldest Person. 100% of the people who failed an attempt died, and the people who do break the record tend not to live for very long after.\n-Unknown",
    "The most popular chair for mobile gaming is a toilet.\n-Unknown",
    "Being able to drink fresh, clean water out of virtually any tap has to be one of the modern worlds greatest luxuries.\n-Unknown",
    "Paranoia is only paranoia if you’re wrong about the thing you’re paranoid about. If you’re right, it’s intuition.\n-Unknown",
    "Most comments are likely deleted before people are even finished typing them because they realise how pointless it is.\n-Unknown",
    "Gravity doesn’t keep you on the floor. The floor stops gravity sucking you down to the planet’s core.\n-Unknown",
    "Most of us will never meet each other.\n-Unknown",
    "If food was priced at $0.01 per calorie, people would chose to eat healthier food with less calories.\n-Unknown",
    "If bomb was said like tomb or womb, it would make the sound a bomb typically makes.\n-Unknown",
    "Grocery stores need a website/app that allows shoppers to input their list and it outputs a map to follow in the store that eliminates back tracking.\n-Unknown",
    "If you described a giraffe and a unicorn to a person who had never seen either, the unicorn sounds a lot more believable.\n-Unknown",
    "If cigarette companies cured cancer cigarette sales could increase.\n-Unknown",
    "You can't feel every hair on your body, but one hair in your mouth is immediately noticeable.\n-Unknown",
    "Death is one of the only things every person experiences but we’ll never be able to discuss what it feel like with anyone.\n-Unknown",
    "The total number of people who are the same age as you can only decrease.\n-Unknown",
    "The brain is technically just electric meat.\n-Unknown",
    "You spend most of your life gathering people to attend your funeral.\n-Unknown",
    "Humans are the only species who decided that water was too boring as a beverage to keep us alive.\n-Unknown",
    "One day you’ll be exactly halfway through your life without ever realising it.\n-Unknown",
    "Self checkout is the customer working as an unpaid employee for two minutes.\n-Unknown",
    "The problem with coffee is that you have to make coffee before you’ve had coffee.\n-Unknown",
    "‘Sleeping alone’ when you are a toddler is a mark of bravery; when you are a teen it is seen as normal and when you are an adult it is a mark of loneliness.\n-Unknown",
    "While we sleep our brain makes up stories and then gets scared of them.\n-Unknown",
    "You never realise how noisy simple tasks are until you need to do them at 3am while everybody is asleep.\n-Unknown",
    "If you are really good at online games and have played for years, the odds are pretty good that you have caused someone to break something in their house out of frustration.\n-Unknown",
    "The more furry the animal the more cute it is. The more furry the human, the more unappealing we are.\n-Unknown",
    "The Teenage Mutant Ninja Turtles are the only crime fighting heroes that wore masks so you could tell who they were.\n-Unknown",
    "Make-a-wish could have been named Final Fantasy.\n-Unknown",
    "Someone has probably beaten an imaginary version of you in an argument while in the shower.\n-Unknown",
    "Muffins are to cupcakes as smoothies are to milkshakes.\n-Unknown",
    "It must really suck to break your arms if you're deaf and need to use sign language.\n-Unknown",
    "Turtles can never have sleepovers because they always sleep in their own homes.\n-Unknown",
    "Having a toddler in their 'why' phase makes you realise how much you know and don’t know about things.\n-Unknown",
    "A psychiatrist is a human brain that’s learned about itself and then uses a meat puppet to talk to another brain’s meat puppet to explain how they function.\n-Unknown",
    "Every word in every language started out as gibberish until one person convinced enough people what they said was a real word.\n-Unknown",
    "Wherever you write in a book it gets slightly heavier.\n-Unknown",
    "You’re the last person that’s gonna die in your lifetime.\n-Unknown",
    "Growing up is getting bored with everything you used to enjoy, without anything really replacing it.\n-Unknown",
    "If you stand back to back with someone, you're facing them with the longest possible distance between you and them.\n-Unknown",
    "Being a baby is so difficult. Imagine utilising all the power to crawl at the end of the room and some elder picking you up and leaving you again at your starting point.\n-Unknown",
    "It is impossible to touch any reflection that isn't your own.\n-Unknown",
    "Technically you have never lost a fight against a dragon.\n-Unknown",
    "We invented plastic that basically lasts forever and decided to use it for single use disposable things.\n-Unknown",
    "The majority of people who use subtitles probably aren’t deaf.\n-Unknown",
    "There’s half a million different jobs in the world yet we pick our careers based on studying 10-15 subjects by age 18-21.\n-Unknown",
    "It's funny how some gamers prefer keyboards, which were not made to play games over other controllers which were specifically made to play games with.\n-Unknown",
    "Snoring must have been a trait developed after we started living in a civilization because there is no way you can survive snoring in the wild without being detected by predators.\n-Unknown",
    "We used to use photos to capture authentic moments, and now we create artificial moments to capture photos.\n-Unknown",
    "When your internet speed test isn't loading, you have everything you need to know.\n-Unknown",
    "The saying 'You’re only a teenager once' isn’t always true since people can live to be 113.\n-Unknown",
    "A cat rubbing you with its face is their way of petting you back.\n-Unknown",
    "Time is an absolutely frightening force. It is completely invisible, never rests for even a moment, gradually kills us all, and we have absolutely no way to stop it or even slow it down.\n-Unknown",
    "Telling people your dog is a ‘boy’ or a ‘girl’ is fine but telling them it’s a ‘man’ or a ‘woman’ sounds weird.\n-Unknown",
    "Every single person will eventually contribute to making the world a better place. Some just do so while living, and the rest do when they die.\n-Unknown",
    "Our brains don't realise they exist until we learn about them in school.\n-Unknown",
    "Erasers slowly sacrifice their lives for our mistakes.\n-Unknown",
    "Good people get angry when you lie about them, bad people get angry when you tell the truth about them.\n-Unknown",
    "Flipping a coin and realising how much you dislike the outcome is more useful for decision making than the actual result of the flip.\n-Unknown",
    "People who procrastinate love doing side quests more than actually finishing the game.\n-Unknown",
    "School group projects prepare you for a world that pays lazy coworkers the same as good coworkers.\n-Unknown",
    "Not having a power socket next to your bed makes you really appreciate having a power socket next to your bed.\n-Unknown",
    "One of the most frustrating feelings in the world is being clever enough to know that there’s a better way to do something but not being clever enough to figure out how to do it.\n-Unknown",
    "Cucumbers and jellyfish are 95% water. There is a 5% difference between a jellyfish and a cucumber.\n-Unknown",
    "The smell of walking into somebody’s house for the first time is different for every single house.\n-Unknown",
    "Eyelashes exist to protect our eyes, but every time there's something in your eye, it's an eyelash.\n-Unknown",
    "An Alzheimer's patient could plan themselves the perfect surprise party.\n-Unknown",
    "Hospitals are the only place that have an emergency entrance and emergency exits.\n-Unknown",
    "Hand sanitizer is good for letting you know how many small cuts you have on your hands.\n-Unknown",
    "Dropping a cup of coffee usually wakes you up more than drinking it.\n-Unknown",
    "Cutting the umbilical cord is like switching the baby from a wired life to a wireless one.\n-Unknown",
    "Someone has probably solved a major world problem in their head at one point but thought it was a bad idea and forgot it.\n-Unknown",
    "Being 5 minutes early to an appointment doesn't feel that early but being 5 minutes late feels really late.\n-Unknown",
    "Alcohol companies never show drunk people in their ads.\n-Unknown",
    "If you gave $20 to someone and never got it back, you basically paid $20 to learn a valuable lesson.\n-Unknown",
    "This has a slight chance of being the last thing you ever read.\n-Unknown",
    "Normally, you empty your drink from the top, but when you use a straw you empty it from the bottom.\n-Unknown",
    "When a criminal steals a police car and gets pursued, it looks like a bunch of cops chasing nothing.\n-Unknown",
    "There is a perfect distance from the sun where popcorn can be made.\n-Unknown",
    "Halloween is more about giving than Christmas is.\n-Unknown",
    "We are really lucky rain comes down in drops instead of all at once.\n-Unknown",
    "If you woke up and had the power to walk through walls it would take you a long time to realise.\n-Unknown",
    "So many inventions throughout history must have been delayed or never even invented because the person that thought of it first assumed it was such a good idea that it must already be a thing.\n-Unknown",
    "Getting older is realising that you don't need to lie about your age when making accounts anymore.\n-Unknown",
    "Eating is the act of grabbing a small piece of the universe and passing it through your body in order to steal some of its energy for yourself.\n-Unknown",
    "A wireless charger restricts your phone much more than a wired one does.\n-Unknown",
    "We find foreign accents attractive because we get sick of hearing our own.\n-Unknown",
    "At some point in your life, someone is gonna snap a photo of you, maybe today, and you won’t think twice about it... and that will be the photo they use at your funeral.\n-Unknown",
    "Every time a rocket is launched into space. The earth slightly reduces in weight.\n-Unknown",
    "After high school you discover you were friends with a lot of people only because you saw them five days per week.\n-Unknown",
    "Being able to read minds would actually suck since with most people you'd just hear the same 5 seconds of a song playing on loop.\n-Unknown",
    "Someone just decided blue ink pens were equally as acceptable as black and everyone just played along.\n-Unknown",
    "A ton (2000 LB) of whales isn’t even a full whale.\n-Unknown",
    "As an adult, having a 'boring desk job' is seen as a bad thing, but we force children to have boring desk jobs for 12+ years.\n-Unknown",
    "There's a single piece of music out there that will please you more than any other piece of music in existence, and chances are pretty good you'll never stumble upon it.\n-Unknown",
    "Your relationship with your cousins is based on your parents' relationship with their siblings.\n-Unknown",
    "Humans are expected to work like robots, yet robots are expected to act like humans.\n-Unknown",
    "Using your significant other’s photo as your phone background is the modern day version of putting their picture in a pocket watch or locket.\n-Unknown",
    "Some parking spaces make more money in an hour than a worker on a minimum wage.\n-Unknown",
    "People who are born during the winter probably have more long sleeve shirts than people born in the summer due to birthday gifts.\n-Unknown",
    "Wet clothes are darker even though water has no colour.\n-Unknown",
    "Denial, anger, bargaining, depression and acceptance are the stages of waking up.\n-Unknown",
    "Babies don't know dreams aren't real, so they must think they have some crazy adventures with you every day.\n-Unknown",
    "The Spanish way of using exclamation marks (putting exclamation marks before and after the sentence) actually makes more sense since you need to know the tone of a sentence before you say it.\n-Unknown",
    "99.9% of animals live their lives without ever burning their tongue.\n-Unknown",
    "Some vampires might get addicted to alcoholics.\n-Unknown",
    "The guy with the highest IQ could just be working an odd job flipping burgers because of a lack of opportunity or interest in doing anything else.\n-Unknown",
    "Glitter is literally 85.7% litter.\n-Unknown",
    "You become a teenager when you realise that sleep is a gift, not a punishment.\n-Unknown",
    "Fake friends are nice to you to your face, but make fun of you behind your back. True friends make fun of you to your face, but always support you behind your back.\n-Unknown",
    "If you put a lasagna on top of a lasagna, it's still 1 lasagna, just with more layers.\n-Unknown",
    "When we hear the word ‘Egyptians’ most of us think about the ancient people who lived there, pharaohs and pyramids instead of the people living in Egypt today.\n-Unknown",
    "Children have a favourite toy. Teenagers have a favourite singer. Adults have a favourite gas station.\n-Unknown",
    "You're never aware of how much noise your house makes until the power goes out.\n-Unknown",
    "Turbulence is the pothole of the sky.\n-Unknown",
    "There are numbers that have never been said aloud.\n-Unknown",
    "Your brain basically enters a fullscreen mode if you watch a video/movie long enough.\n-Unknown",
    "Google is being widely used as a spell checker.\n-Unknown",
    "The voice in your head is incredible at impersonations.\n-Unknown",
    "Showers are brains taking their vehicles for a wash.\n-Unknown",
    "Ads are total waste to 99% people, they probably stare at the skip button or the close button during the entire ad.\n-Unknown",
    "‘I need to talk to you’ is the one sentence that has the power to make you remember every bad thing you've ever done in your life.\n-Unknown",
    "There's probably a person you completely forgot about and you’ll never be able to remember who they are.\n-Unknown",
    "Bees build homes with their mouths and defend with their butts. Spiders build homes with their butts and defend with their mouths.\n-Unknown",
    "Since the ocean has meat, salt and vegetables in it, it is technically a giant soup.\n-Unknown",
    "The word ‘suns’ upside down is ‘suns’.\n-Unknown",
    "The number 6 is three-fourths of the number 8 in both value and appearance.\n-Unknown",
    "Oxygen might have a taste and smell but our brains could’ve learned to ignore it early on.\n-Unknown",
    "Hot headed is bad, but warm hearted is good. Cool headed is good, but cold hearted is bad.\n-Unknown",
    "The moment that you hit one million dollars net worth, you are officially the poorest millionaire in the world.\n-Unknown",
    "Actors who are playing a scene where they are pretending to be actors who are acting badly in a scene are actually doing a really good job of acting.\n-Unknown",
    "‘Scrubbing’ is a combination of scratching and rubbing.\n-Unknown",
    "If you choke while drinking water, you've failed at a simple task in which you have a lifetime of experience.\n-Unknown",
    "A decade is ending every second because a decade is 10 years no matter the starting date.\n-Unknown",
    "On our birthday, we celebrate our individual trips around the sun. On New Years, we celebrate trips around the sun together.\n-Unknown",
    "Dragons probably think it's cool that we can make water in our mouths.\n-Unknown",
    "Being negative is great! You're either always right or pleasantly surprised.\n-Unknown",
    "When you introduce two different groups of friends to each other, it's like your own life's crossover episode.\n-Unknown",
    "When you are sick, you are told to do drugs and stay out of school.\n-Unknown",
    "Eating is pretty weird as you shove food into a hole of your body and then smash it to pieces with 36 little bones and then a meat tentacle shoves it into a pool of acid.\n-Unknown",
    "Your 2nd birthday is the only birthday when you double your age.\n-Unknown",
    "One brick is good for attacking, but a lot of bricks are good for defending.\n-Unknown",
    "we praise photographs that look like drawing and drawings that look like photographs.\n-Unknown",
    "There is nothing better than realizing, right after you wake up, that you won't have to face repercussions for the terrible choices you made in your dream.\n-Unknown",
    "People who use anti-aging creams must have the youngest looking fingertips on earth.\n-Unknown",
    "Sneezing is really weird. Your nose briefly transforms into a cannon that launches snot at the speed of a sports car, then you go about your business as if you hadn’t just had your face weaponized.\n-Unknown",
    "Getting paid minimum wage is your employer’s way of telling you 'we would pay you less if we could, but we can’t'.\n-Unknown",
    "$0.99 seems so much more expensive on the App Store than in a real store.\n-Unknown",
    "Yawning is your body’s 15% battery notification.\n-Unknown",
    "Due to the New Years countdown, the last word of millions of people say each year is 'one'.\n-Unknown",
    "The strangest human ability is to remember that we have forgotten something, but can’t remember what we have forgotten.\n-Unknown",
    "Metals are extracted from rocks, and metal music is derived from rock music.\n-Unknown",


    "Kids hate their school until another school puts it down, people hate their jobs until an outsider makes fun of their job and the human race will never work together until an outside force threatens our planet.\n-Unknown",
    "I wonder how many miles my mouse has travelled in total.\n-Unknown",
    "Girls named Elizabeth will sometimes use the nicknames Elle, Liz, or Beth, but the never use the third syllable: Zab.\n-Unknown",
    "As humans, we often wish we were able to fly like birds, yet we take for granted our ability to swim like fish.\n-Unknown",
    "Coffee makes you energetic, but coffee shops are intended to make you slow down and relax.\n-Unknown",
    "What if déjà vu is just you losing a life and starting again at the last checkpoint?\n-Unknown",
    "Biting your tongue while eating is a perfect example of how you can still screw up, even with decades of experience.\n-Unknown",
    "Your future self is talking crap about you.\n-Unknown",
    "Firefly is the opposite of waterfall.\n-Unknown",
    "You only have 1 birthday, the rest are congratulations for surviving each year.\n-Unknown",
    "Whatever happens inside our bodies happens in pitch-black darkness.\n-Unkown",
    "Some stranger remembers you for being kind to them when no one else was.\n-Unknown",
    "Therapists talk you into brainwashing yourself.\n-Unkown",
    "On any given day in a hospital, you can find people having the best day of their life, the worst day of their life, the first day of their life, and the last day of their life all under one roof.\n-Unknown",
    "Every single decision you've made in your life has led you to where you are now.\n-Unknown",
    "Someone out there vividly remembers something you said that you have completely forgotten.\n-Unknown",
    "You see people every single day that you'll never see again.\n-Unknown",
    "You may have once made a decision that saved your life without knowing it.\n-Unknown",
    "Kids are bullied for being different while adults are praised for being different.\n-Unknown",
    "People cover their laptop cameras for fear of hackers, but never their phone cameras.\n-Unknown",
    "Being an air conditioning repair person must be hard because it's hot when you arrive and as soon as it's cooled down, you leave.\n-Unknown",
    "The first person to inhale helium was probably so relieved that the effects wore off quickly.\n-Unknown",
    "Finding worms in apples has been much less of a problem than I anticipated experiencing as a kid.\n-Unknown",
    "The way we treat moths versus butterflies is a real-life example of pretty privilege.\n-Unknown",
    "You're the only one that remembers your embarrassing experiences so vividly because everyone's got their own to remember.\n-Unknown",
    "If a morgue worker died, they'd still need to come into work.\n-Unknown",
    "Generally speaking, when you feel stupid, it's because you're expanding your knowledge and getting smarter.\n-Unknown",
    "If humans could fly, we'd probably consider it exercise and never do it.\n-Unknown",
    "If 24-hour clocks started at 23:59 and counted down till 00:01, people might try getting more done everyday.\n-Unknown",
    "Whoever created the tradition of not seeing the bride in the dress before the wedding saved husbands everywhere from hours of dress shopping.\n-Unknown",
    "We're lucky blinking doesn't make a noise.\n-Unknown",
    "Salt is the only rock that is socially acceptable to eat\n-Unknown",
    "Have you ever said, 'Hey, stranger' to someone you didn't know?\n-Unknown",
    "Once we have self-driving cars, wipers will no longer be essential, because the car doesn’t need a clean windshield to drive.\n-Unknown",
    "There are two E's in bee, but they're both silent.\n-Unknown",
    "The only difference between relaxation and boredom is enjoyment.\n-Unknown",
    "You've never actually seen a full movie because you're always blinking.\n-Unknown",
    "If a fly loses its wings, is it now called a walk?\n-Unkown",
    "Finally is pronounced 'final-e' and finale is pronounced 'fi-nally.'",
    "Youth is a paradox, because you want to be healthy and make good habits and setup your career, but you also want to have fun so you don't end up regretting missing out on your younger years when you get older.\n-u/CWJMajor19",
    "There are 7500 apple varieties, but just one apple juice.\n-u/SaurikSI",
    "You've never seen a microwave commercial. Yet almost every household has one.\n-u/The_Undermind",
    "Somewhere out there exists the most average human who satisfies the highest number of statistical averages\n-u/Alex_Alex_2005",
    "We laugh at dogs getting excited when they hear a bark on TV, but if TV was a nonstop stream of unintelligible noises and then someone suddenly spoke to you in your language, you'd be startled too.\n-u/Biles",
    "When you're a kid, you don't realize you're also watching your mom and dad grow up.\n-u/zjb55446",
    "If elevators hadn't been invented, all the CEOs and important people would have their offices on the first floor as a sign of status.\n-Unknown",
    "We do not check the refrigerator multiple times to find new food, we check to see if our standards have dropped enough to eat what was available.\n-u/Cryptic_Cosmos",
    "It would be cool if after you died you could see the top 5 times you almost died.\n-Unknown",
    "Since there are 3600 seconds in an hour, and most people make less than $36.00/hr, their time is worth less than a penny per second. It's literally worth your time to pick up a penny from the ground.\n-u/ThatOneRoadie",
    "Humans cannot even live in harmony with their own species and somehow still convince themselves that meeting an extra-terrestrial species would go smoothly\n-Unknown",
    "Watching a graduation ceremony is like sitting through a movie thats entirely end credits\n-u/definitelyusername",
    "Running from the cops is the ultimate double or nothing.\n-u/PBCaptnCrunch",

    "You’re just stealing happiness from tomorrow when you drink alcohol.\n-Unknown",
    "The word 'Fat' looks like the first letter of the word 'Eat' has been chewed off.\n-Unknown",
    "We build houses to protect us from the environment, but we love going outside during the hottest and coldest months.\n-Totem",
    "Chicken is only a breakfast item if it's not born yet.\n-Unknown",
    "Old people drive like they have all the time in the world while young people drive like they're constantly running out of time.\n-Unknown",
    "Gen Z could be the last generation on the planet to know what it’s like to wake up early in the morning and watch your favorite cartoon on TV.\n-Unknown",
    "We go to the office by car from the same route everyday but never encounter the same cars along the way.\n-Unknown",
    "Painkillers act as a mute the notification option for your body.\n-Unknown",
    "The syllables in 'on your mark, get set, go' is a countdown.\n-Unknown",
    "There are hundreds of Rubik’s cubes that are not solved yet and may never be solved.\n-Unknown",
    "People celebrate 31st December every year but never celebrate 29th February even though it comes only once every 4 years.\n-Unknown",
    "The night before your day off is more relaxing than your actual day off.\n-Unknown",
    "The internet killed the mail industry (by replacing mailed letters with online messages) but then revived it with everyone ordering packages.\n-Unknown"

    };
    
    public int[] favoriteThought; //the favorite thought index array
    int[] favoriteThoughtCheck; 

    private void Awake() {
        //initialize the favorite thought array
        favoriteThought = PlayerPrefsX.GetIntArray("Favorites");

        //if there is atleast one favorite thought saved
        if (favoriteThought.Length != 0)
            favoriteThought = PlayerPrefsX.GetIntArray("Favorites");
        else favoriteThought = new int[300];
    }

    //this method adds a thought to the array of favorite thoughts
    public void AddThoughtToFavorites(int thoughtNum) {
        //for all the elements in the favorite thought array (parameter of index of thought to save)
        for (int i = 0; i < favoriteThought.Length; i++) {
            //if there is a free space, fill it with the array parameter
            if (favoriteThought[i] == 0) {
                favoriteThought[i] = thoughtNum;
                break;
            }
        }
    }
    //this method removes a thought from the array of favorite thoughts
    public void RemoveThoughtFromFavorites(int thoughtNum) {
        //for all the elements in the favorite thought array
        for (int i = 0; i < favoriteThought.Length; i++) {
            //remove the thought in the index being searched for
            if (favoriteThought[i] == thoughtNum) favoriteThought[i] = 0;

            if (i != favoriteThought.Length && i != favoriteThought.Length - 1) {
                //if the current thought is 0 but the next thought isnt, move the non-zero value to the left
                if (favoriteThought[i] == 0 && favoriteThought[i + 1] != 0) {
                    favoriteThought[i] = favoriteThought[i + 1]; //set current thought to the next one
                    favoriteThought[i + 1] = 0; //set next thought to the current one
                }
            }
        }
    }
    public bool IsThoughtAlreadyFavorited(int thoughtNum) {
        bool wasThoughtFound = false;
        //for all the elements in the favorite thought array
        for (int i = 0; i < favoriteThought.Length; i++) {
            //if the thought is found, set to true and break
            if (favoriteThought[i] == thoughtNum) {
                wasThoughtFound = true;
                break; //if the thought is found
            }
        }
        return wasThoughtFound;
    }
    //this method returns the value of the index before the parameter
    public int StepBack(int thoughtNum) {
        int previousNum = 0;
        for (int i = 0; i < favoriteThought.Length; i++) {
            //if the thought is found and isnt at index 0, return value of number before it 
            if (favoriteThought[i] == thoughtNum && i != 0) {
                previousNum = favoriteThought[i - 1];
                break;
            }
            //otherwise, return the number at the last index
            else if (favoriteThought[i] == thoughtNum && i == 0) {
                //for the length of the array, traverse backwards until a number that isnt 0 is found
                for (int j = favoriteThought.Length - 1; j >= 0; j--) {
                    //if the current number isnt a 0, set it to the variable
                    if (favoriteThought[j] != 0) {
                        previousNum = favoriteThought[j];
                        break;
                    }
                }

            }
        }
        return previousNum;
    }
    public int StepForward(int thoughtNum) {
        int nextNum = 0;
        for (int i = 0; i < favoriteThought.Length; i++) {
            //if the thought is found and the current index isnt the last index, return the next available index
            if (favoriteThought[i] == thoughtNum && i != favoriteThought.Length - 1) {
                //continuing the array traversal from the point where 'i' left off, until the last index of the array
                for (int j = i; j < favoriteThought.Length; j++) {
                    //if the current index isnt 0, set the current index to the variable
                    if (favoriteThought[j] != 0 && i != j) {
                        nextNum = favoriteThought[j];
                        break;
                    }
                    //if 'j' makes it to the empty array storage and still hasnt found an available number, return the first index
                    if (favoriteThought[j] == 0) {
                        nextNum = favoriteThought[0];
                        break;
                    }
                }
            }
            //else if the thought is found and the current index is the last index, return the first index
            else if (favoriteThought[i] == thoughtNum && i == favoriteThought.Length - 1) {
                nextNum = favoriteThought[0];
                break;
            }
        }
        return nextNum;
    }

    //returns the number of filled indexes in the favorites thought array
    public int NumberOfFavoriteThoughts() {
        int numberOfFavoriteThoughts = 0;
        for (int i = 0; i < thoughts.Length; i++) { //for the number of thoughts
            if (favoriteThought[i] != 0) numberOfFavoriteThoughts++; //increment 
            else break; //if the index is not filled break
        }
        return numberOfFavoriteThoughts;
    }

    //this method finds the index number of the given favorite thought
    public int FindFavoriteThoughtIndexNumber(int thoughtNum) {
        int thoughtIndex = 0;
        //traverse through the array of thoughts
        for (int i = 0; i < favoriteThought.Length; i++) {
            //if the given thought number matches the current index, set the variable to the index
            if (favoriteThought[i] == thoughtNum) {
                thoughtIndex = i + 1;
                break;
            }
        }
        //return the index of the thought
        return thoughtIndex;
    }
    public void UpdateFavoritesList() {
        PlayerPrefsX.SetIntArray("Favorites", favoriteThought);
        favoriteThought = PlayerPrefsX.GetIntArray("Favorites");
    }

    //this method gets a thought
    public string GetThought(int num) {
        return thoughts[num]; //return the thought at the parameter index
    }

    //this methhod returns jthe number of thoughts
    public int NumberOfThoughts() {
        return thoughts.Length; //return the array length
    }
}
