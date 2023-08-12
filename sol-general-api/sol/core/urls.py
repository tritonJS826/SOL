from django.contrib import admin
from django.urls import path, include
from drf_spectacular.views import SpectacularAPIView, SpectacularSwaggerView

from core.settings import DEBUG

urlpatterns = [
    path("django-admin/", admin.site.urls),
    path("api/", include("apps.general.urls")),
    path("api/schema/", SpectacularAPIView.as_view(), name="schema"),
    path("api/schema/swagger-ui/", SpectacularSwaggerView.as_view(url_name="schema"), name="swagger-ui"),
]
if DEBUG:
    urlpatterns.append(path("silk/", include("silk.urls", namespace="silk")))

