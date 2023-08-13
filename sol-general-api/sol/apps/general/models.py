from django.core.validators import MaxValueValidator, MinValueValidator
from django.db import models
from django.contrib.postgres.fields import ArrayField
import uuid
from django.contrib.auth import get_user_model

User = get_user_model()


class Profile(models.Model):
    """Stores profile info"""

    uuid = models.UUIDField(primary_key=True, default=uuid.uuid4, editable=False)
    user = models.ForeignKey(User, on_delete=models.CASCADE)

    def __str__(self):
        return f"{self.user.login}"


class World(models.Model):
    """Stores world info"""
    
    uuid = models.UUIDField(primary_key=True, default=uuid.uuid4, editable=False)
    name = models.CharField(max_length=255, null=False, blank=False)
    description = models.TextField(null=False, blank=False)
    created = models.DateTimeField(auto_now_add=True)
    updated = models.DateTimeField(auto_now=True)
    user = models.ForeignKey(User, on_delete=models.CASCADE)
    level_order_ids = ArrayField(models.UUIDField()) 

    def __str__(self):
        return f"{self.name}"


class Level(models.Model):
    """Stores level info"""
    
    uuid = models.UUIDField(primary_key=True, default=uuid.uuid4, editable=False)
    title = models.CharField(max_length=255, null=False, blank=False)
    description = models.TextField(null=False, blank=False)
    world = models.ForeignKey(World, on_delete=models.CASCADE)
    created = models.DateTimeField(auto_now_add=True)
    updated = models.DateTimeField(auto_now=True)
    wave_order_ids = ArrayField(models.UUIDField()) 

    def __str__(self):
        return f"{self.title}"


class Wave(models.Model):
    """Stores wave info"""
    
    uuid = models.UUIDField(primary_key=True, default=uuid.uuid4, editable=False)
    delay_time = models.PositiveIntegerField(validators=[MinValueValidator(1000), MaxValueValidator(86400000)])
    level = models.ForeignKey(Level, on_delete=models.CASCADE)
    created = models.DateTimeField(auto_now_add=True)
    updated = models.DateTimeField(auto_now=True)
    enemy_order_ids = ArrayField(models.UUIDField()) 

    def __str__(self):
        return f"wave_{self.uuid}"


class QuestionGroup(models.Model):
    """Stores question related data"""

    uuid = models.UUIDField(primary_key=True, default=uuid.uuid4, editable=False)
    question = models.TextField(null=False, blank=False)
    answer = models.TextField(null=False, blank=False)
    user = models.ForeignKey(User, on_delete=models.CASCADE)
    created = models.DateTimeField(auto_now_add=True)
    updated = models.DateTimeField(auto_now=True)

    def __str__(self):
        return f"question_{self.uuid}"


class Enemy(models.Model):
    """Stores enemy info"""
    
    class EnemyType(models.TextChoices):
        """Enumerated enemy types."""

        CIRCLE = "CIRCLE", "Circle"


    uuid = models.UUIDField(primary_key=True, default=uuid.uuid4, editable=False)
    question_group = models.ForeignKey(QuestionGroup, on_delete=models.CASCADE)
    user = models.ForeignKey(User, on_delete=models.CASCADE)
    enemy_type = models.CharField(max_length=255, null=False, blank=False, choices=EnemyType.choices) 
    waves = models.ManyToManyField(Wave, blank=True, related_name="enemies")
    created = models.DateTimeField(auto_now_add=True)
    updated = models.DateTimeField(auto_now=True)

    def __str__(self):
        return f"enemy_{self.uuid}"

