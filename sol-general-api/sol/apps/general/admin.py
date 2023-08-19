from django.contrib import admin
 
from .models import World, Level, Wave, Enemy, QuestionGroup


admin.site.register(World)
admin.site.register(Level)
admin.site.register(QuestionGroup)
admin.site.register(Wave)
admin.site.register(Enemy)

