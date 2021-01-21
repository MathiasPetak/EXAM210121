Feature: SpecFlowFeature1
	In order to calculate
	As a student
	I want to solve trigonometric operations

@mytag
Scenario: Calculate sinus
	Given the angle is Pi
	When sinus of the angle is calculated
	Then the result should be 0

	Scenario: Calculate cosinus
	Given the angle is Pi
	When cosinus of the angle is calculated
	Then the result should be -1

	Scenario: Calculate tangens
	Given the angle is Pi
	When tangens of the angle is calculated
	Then the result should be 0