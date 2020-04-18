# 18/04/2020

## WHAT DID

- read chapter 6
- fall down the pit kill the player
- add HealthBar UI
- add HealthBarUI script
- investigate HealthBarUI script

## WHAT LEARNED

- Mathf.Clamp(float value, float min, float max) (asign this to a value to restrict it in range of min, max value
- float value = Mathf.Clamp(value, -10, 10); <- value will restricted between -10 and 10 if value = 11; then value will be 10.
- Mathf.MoveTowards(float current, float target, float maxDelta) (Moves a value current towards target)
- maxDelta -> The maximum change that should be applied to the value.
- Time.deltaTime(return the time between each frame)

## WHAT WILL DO

- finish chapter 6

# 17/04/2020

## WHAT DID

- read chapter 6
- Fix many problems
- add Health
- add KillZone

## WHAT LEARNED

## WHAT WILL DO

- finish chapter 6

# 15/04/2020

## WHAT DID

- Fix PlayerControl script(character jump doesn't work)
- Read chapter 6
- Add LevitatingPlatform script
- Investigate and understand LevitatingPlatform script
- Add scene 2

## WHAT LEARNED

- New code from UE
- Mathf.pingpong(float a, float b) return value that move back and forth between 2 value;

## WHAT WILL DO

- Add scene 3
- Read chapter 6
 
# 12/04/2020

## WHAT DID

- Read chapter 5
- Add PlayerControl script
- Investigate PlayerControl script
- Optimize project
- Do Q%A
- Q%A answer: 1.B 2.B 3.A 4.A
- Finish chapter 5

## WHAT LEARNED

- New code from Unity Engine
- FACEDIRECTION
- Sprite packing

## WHAT WILL DO

- read chapter 6

## WHAT WILL DO


# 11/04/2020

## WHAT DID

- Read chapter 5
- Add Background/Foreground
- Add Enviroment physics/ platforms
- Add Player sprites and body parts

## WHAT LEARNED

- Multi sprites
- 2D collisons, 2D rigidbody

## WHAT WILL DO

- Add player movement script
- Finish chapter 5

# 09/04/2020

## WHAT DID

- Make a Score UI
- Do Q%A
- Q&A answer: 1.B 2.B 3.A 4.A
- Finish chapter 4
- Read chapter 5
- Add new 2D Platformer Project 

## WHAT LEARNED

- User Input config
- Making UI

## WHAT WILL DO

- read Chapter 5

# 07/04/2020

## WHAT DID

- Add new projectile
- Add Enemy ability to fire projectile

## WHAT LEARNED

## WHAT WILL DO

- Read Chapter 4
- Finish Chapter 4

# 05/04/2020

## WHAT DID

- Add custom player's gun (which shoot energy beam)
- Make Enerby Beam spawn when player press leftclick and travel like a bullet
- Make Enerby Beam do damage and destroy it self upon impact or went offscreen(destroy the object itself)
- Add a child to Enemy that hold Detector collison to separeate from Enemy hitbox(both are collison so enemy hit detection collison will do damage to enemy)
- Read Chapter 4
- Many tweaks and fixes

## WHAT LEARNED

- New Code from Unity Engine

## WHAT WILL DO

- Add Enemy's gun(projectile)
- Read Chapter 4
- Finish Chapter 4

## NOTE TO MYSELF

- use DestroyObject to destroy game object NOT destroy

# 04/04/2020

## WHAT DID

- Add Spawner cap
- Add Enemy will follow Player
- Add Enemy will stop if already in certain range from the player(so they wont run player down)
- Read Chapter 4
- Add Energy Beam(Player projectile)
- Add new Scripts
- Make the camera follow player smoothly

## WHAT LEARNED

- New code from Unity Engine
- Distance (Vector3.Distance(vector a, vector b) return distance between 2 object position)
- Better understand on navigating around objects using tag and reference
## WHAT WILL DO

- Finish Chapter 4

# 02/04/2020

## WHAT DID

- Read Chapter 3
- Add Spawner(enemy spawner)
- Finish Chapter 3

## WHAT LEARNED

- New code from Unity Engine
- Instantiate(make a clone of given oject)
- FindObjectWithTag(Tag) (as the name describe it return the oject hold given tag)

## WHAT WILL DO

- Chapter 4

# 01/04/2020

## WHAT DID

- watch multiple explaination videos on youtube, tutorials

## WHAT LEARNED

- How to create Animation objects
- Animation stuff
- Pixel arts

# 31/03/2020

## WHAT DID

- Read Health
- Read Death and particles
- Add Health
- Add Particles on Death

## WHAT LEARNED

- Health
- Death and particles
- New Unity codes
- SendMessage
- SendMessageOptions.DontRequireReceiver(if 0 receiver then nothing happen)
- Instantiate(provoke given object)

## WHAT WILL DO

- Finish chapter 3

# 30/03/2020

## WHAT DID

- Research AddForce and how unity physics work
- Finish customize PlayerController script(make it work)

## WHAT LEARNED

- Unity physics
- Add force

## WHAT WILL DO

- Finish chapter 3

# 29/03/2020

## WHAT DID

- Read chapter 3(Bounds locking)
- Recreate new Void Space project (old project got lost)
- Add Background(Space background, Planets..)
- Add BondsLock script(map boundary)
- Update PlayerController script

## WHAT LEARNED

- New code from unity engine
- Camera.main.ScreenToWorldPoint
 Input.GetAxis
+ Input.mousePosition

## WHAT WILL DO

- Complete PlayerController script

## NOTE TO MYSELF

- Vector3 MousePosWorld = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.0f));
- MousePosWorld = new Vector3(MousePosWorld.x, 0.0f, MousePosWorld.z);
- Vector3 LookDirection = MousePosWorld - ThisTransform.position;
- ThisTransform.localRotation = Quaternion.LookRotation(LookDirection.normalized,Vector3.up);
- Use to rotate Object to Player mouse position
- Input.GetAxis is input from keybroad(Vert == W/S, Horz == A/D)
- Input.mousePosition == mouse position (child == .x && .y && .z).
- ThisBody.AddForce where ThisBody represent the object
- AddForce will add magnetic force to the object coresponding given 3d vector

# 28/03/2020

## WHAT DID

- Read chapter 3 (from the start of the chapter to Bounds locking)
- Develop new Project(game) named Void Space
- Commit new Build to Builds branch

## WHAT LEARNED

- New code from unity

## WHAT WILL DO
- Finish chapter 3

# 26/03/2020

## WHAT DID

- Read chapter 2 (project structure)
- Book Q&A
- Test your knowledge
- Did QA questions
   
## WHAT LEARNED

- New code from unity
- New hotkeys
- Prefabable objects
- Build project to executeable application
	
## WHAT WILL DO
- Chapter 3
	
## NOTE
- Put the game folder in the same folder