from django.shortcuts import get_object_or_404, render
from .models import Project

def home(request):
    # This view will display the homepage with a list of projects
    projects = Project.objects.all()
    return render(request, 'home.html', {'projects': projects})

def project_detail(request, pk):
    # This view will display the details of a single project
    project = get_object_or_404(Project, pk=pk)
    return render(request, 'project_detail.html', {'project': project})

def about(request):
    # This view will display the about page
    return render(request, 'about.html')
