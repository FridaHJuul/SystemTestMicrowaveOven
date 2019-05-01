Feature: MicrowavePower
	I want to cook or heat my food at the correct power and time

@powerIsPressedOnce
Scenario: Press the power button 1 time(s) and the time button 1 time(s)
	Given the oven is reset
	When I press the power button 1 time(s)
	And I press the time button 1 time(s)
	Then the display should show 01:00
