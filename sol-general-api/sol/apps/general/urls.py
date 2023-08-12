from rest_framework import routers

from .views import WorldViewSet

app_name = "general"

router = routers.SimpleRouter()
router.register("worlds", WorldViewSet)

urlpatterns = router.urls

