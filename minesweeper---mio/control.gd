extends Control

var player_name = "Player"

func _ready():
	var message = build_message()
	$GreetingLabel.text = message
	print(message)

func build_message():
	return "Hello, " + player_name + "! Welcome to Sharksweeper🦈"
