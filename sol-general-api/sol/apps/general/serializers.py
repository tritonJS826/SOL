from rest_framework.serializers import ModelSerializer

from .models import World, Level, Wave, Enemy


class EnemySerializer(ModelSerializer):
    class Meta:
        model = Enemy 
        exclude = ("created", "updated", "waves")


class WaveSerializer(ModelSerializer):
    enemies = EnemySerializer(many=True)

    class Meta:
        model = Wave 
        exclude = ("created", "updated")


class LevelSerializer(ModelSerializer):
    waves = WaveSerializer(many=True, source="wave_set")

    class Meta:
        model = Level 
        exclude = ("created", "updated")


class WorldSerializer(ModelSerializer):
    levels = LevelSerializer(many=True, source="level_set")

    class Meta:
        model = World 
        exclude = ("created", "updated")

