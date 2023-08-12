from django.core.validators import MaxValueValidator, MinValueValidator
from django.db import models


class World(models.Model):
    """Stores world info"""
    
    name = models.CharField(max_length=255, null=False, blank=False)
    description = models.TextField(null=False, blank=False)
    created = models.DateTimeField(auto_now_add=True)
    updated = models.DateTimeField(auto_now=True)

    def __str__(self):
        return f"{self.name}"


class Level(models.Model):
    """Stores level info"""
    
    title = models.CharField(max_length=255, null=False, blank=False)
    description = models.TextField(null=False, blank=False)
    world = models.ForeignKey(World, on_delete=models.CASCADE)
    created = models.DateTimeField(auto_now_add=True)
    updated = models.DateTimeField(auto_now=True)

    def __str__(self):
        return f"{self.title}"


class Wave(models.Model):
    """Stores wave info"""
    
    delay_time = models.PositiveIntegerField(validators=[MinValueValidator(1000), MaxValueValidator(86400000)])
    level = models.ForeignKey(Level, on_delete=models.CASCADE)
    created = models.DateTimeField(auto_now_add=True)
    updated = models.DateTimeField(auto_now=True)

    def __str__(self):
        return f"wave_{self.id}"


class Enemy(models.Model):
    """Stores enemy info"""
    class EnemyType(models.TextChoices):
        """Enumerated enemy types."""

        CIRCLE = "CIRCLE", "Circle"


    question = models.TextField(null=False, blank=False)
    answer = models.TextField(null=False, blank=False)
    enemy_type = models.CharField(max_length=255, null=False, blank=False, choices=EnemyType.choices) 
    waves = models.ManyToManyField(Wave, blank=True, related_name="enemies")
    created = models.DateTimeField(auto_now_add=True)
    updated = models.DateTimeField(auto_now=True)

    def __str__(self):
        return f"enemy_{self.id}"

