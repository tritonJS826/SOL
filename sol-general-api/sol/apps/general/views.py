from rest_framework.mixins import ListModelMixin, RetrieveModelMixin
from rest_framework.viewsets import GenericViewSet

from .models import World
from .serializers import WorldSerializer


class WorldViewSet(GenericViewSet, ListModelMixin, RetrieveModelMixin):
    """Worlds viewset."""

    queryset = World.objects.all()
    serializer_class = WorldSerializer

